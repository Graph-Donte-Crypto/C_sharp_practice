using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace C_sharp_practice.Task9 {
	public class DirectoryViewer {

		DirectoryInfo directoryInfo;

		DirectoryInfo[] subdirectories;
		FileInfo[] files;
		string[] menuStrings;

		string fileFullName;
		string[] fileStrings;

		int upperIndex = 0;
		int index = 0;
		bool inFile = false;
		public DirectoryViewer() { 
			
		}
		string guaranteedSizeString(string s, int size) {
			if (s.Length > size) 
				return s.Substring(0, size - 3) + "...";
			else if (s.Length < size) 
				return s += new string(' ', size - s.Length);
			else
				return s;
		}

		void updateDirectoryInformation() {
			subdirectories = directoryInfo.GetDirectories();
			files = directoryInfo.GetFiles();
			menuStrings = new string[subdirectories.Length + files.Length];
			for (int i = 0; i < subdirectories.Length; i++)
				menuStrings[i] = i.ToString("D4") + " | " + guaranteedSizeString(subdirectories[i].Name, 50) + " | Directory";
			for (int i = subdirectories.Length; i < files.Length + subdirectories.Length; i++)
				menuStrings[i] = i.ToString("D4") + " | " + guaranteedSizeString(files[i - subdirectories.Length].Name, 50) + " | File";
		}

		void drawSelectedLine(string line) {
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.White;
			Console.WriteLine(line);
			Console.ResetColor();
		}

		//Redraw strings with selection
		void redraw(string[] strings) {
			Console.Clear();
			StringBuilder optimizedOutput = new StringBuilder();
			optimizedOutput.Append("Use Left/Right and Up/Down to navigate. Q to exit\n");

			for (int i = upperIndex; i < index; i++)
				optimizedOutput.Append(guaranteedSizeString(strings[i], Console.WindowWidth - 1) + '\n');

			Console.Write(optimizedOutput);

			drawSelectedLine(guaranteedSizeString(strings[index], Console.WindowWidth - 1));

			optimizedOutput.Clear();

			for (int i = index + 1; i < strings.Length && i < upperIndex + Console.WindowHeight - 2; i++) 
				optimizedOutput.Append(guaranteedSizeString(strings[i], Console.WindowWidth - 1) + '\n');
			
			Console.Write(optimizedOutput);

			Console.SetCursorPosition(0, Console.WindowHeight - 1);
			Console.Write("index: " + index + " upperIndex: " + upperIndex);
		}

		//Select line with new index. Redraws automatically
		void selectionMove(string[] strings, int newIndex) {
			if (newIndex < upperIndex) {
				upperIndex = newIndex;
				index = newIndex;
				redraw(strings);
			}
			//(Console.WindowHeight - 3) because:
			//-1 for instruction line
			//-1 for line with indexes
			//-1 for numering from 0
			else if (newIndex > upperIndex + Console.WindowHeight - 3) {
				upperIndex += newIndex - upperIndex - Console.WindowHeight + 3;
				index = newIndex;
				redraw(strings);
			}
			else {
				//to current selectred string
				Console.SetCursorPosition(0, index + 1 - upperIndex);
				Console.ResetColor();
				Console.WriteLine(guaranteedSizeString(strings[index], Console.WindowWidth - 1));

				//to new selectes string
				Console.SetCursorPosition(0, newIndex + 1 - upperIndex);
				drawSelectedLine(guaranteedSizeString(strings[newIndex], Console.WindowWidth - 1));
				Console.SetCursorPosition(0, Console.WindowHeight - 1);

				index = newIndex;
				Console.Write("index: " + index + " upperIndex: " + upperIndex);
			}
			
		}

		
		public void view(string path = null) {

			directoryInfo = new DirectoryInfo(path != null ? null : Directory.GetCurrentDirectory());
			updateDirectoryInformation();
			index = 0;
			redraw(menuStrings);

			while (true) {
				ConsoleKey key = Console.ReadKey().Key;
				if (key == ConsoleKey.Q)
					break;
				else if (key == ConsoleKey.LeftArrow) {

					if (inFile) {
						inFile = false;
						index = subdirectories.Length;
						for (int i = 0; i < subdirectories.Length; i++) {
							if (fileFullName == files[i].FullName) {
								index += i;
								break;
							}
						}
					}
					else {
						string directoryName = directoryInfo.Name;
						directoryInfo = new DirectoryInfo(directoryInfo.FullName + Path.DirectorySeparatorChar + "..");
						updateDirectoryInformation();
						index = 0;
						for (int i = 0; i < subdirectories.Length; i++) {
							if (directoryName == subdirectories[i].Name) {
								index = i;
								break;
							}
						}
					}

					redraw(menuStrings);
				}
				else if (key == ConsoleKey.RightArrow) {
					if (!inFile) {
						if (index >= subdirectories.Length) {
							inFile = true;
							fileFullName = files[index - subdirectories.Length].FullName;
							
							fileStrings = File.ReadAllLines(files[index - subdirectories.Length].FullName);
							index = 0;
							upperIndex = 0;
							redraw(fileStrings);
						}
						else {
							directoryInfo = subdirectories[index];
							updateDirectoryInformation();
							index = 0;
							upperIndex = 0;
							redraw(menuStrings);
						}
					}
				}
				else if (key == ConsoleKey.UpArrow) {
					if (index > 0) {
						if (inFile)
							selectionMove(fileStrings, index - 1);
						else
							selectionMove(menuStrings, index - 1);
					}
				}
				else if (key == ConsoleKey.DownArrow) {
					if (inFile) {
						if (index < fileStrings.Length - 1) 
							selectionMove(fileStrings, index + 1);
					}
					else {
						if (index < subdirectories.Length + files.Length - 1) 
							selectionMove(menuStrings, index + 1);
					}
				}
			}
		}
	}
}

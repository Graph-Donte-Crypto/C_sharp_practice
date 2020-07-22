using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using Newtonsoft.Json;

namespace C_sharp_practice.Task10 {
	public class Book {
		string name { get; set; }
		string author { get; set; }
		int year { get; set; }
		int pages { get; set; }
		string content { get; set; }
		public Book(string name, string author, int year, int pages, string content) {
			this.name = name;
			this.author = author;
			this.year = year;
			this.pages = pages;
			this.content = content;
		}
		public Book() {
		}

		public void loadFromXml(string filename) {

			string xml = File.ReadAllText(filename);
			using (StringReader stringReader = new StringReader(xml)) {
				using (XmlReader xmlReader = XmlReader.Create(stringReader,
					new XmlReaderSettings() { IgnoreWhitespace = true })) {
					xmlReader.MoveToContent();
					//xmlReader.ReadStartElement("Book");

					name = xmlReader.GetAttribute("name");
					author = xmlReader.GetAttribute("author");
					year = int.Parse(xmlReader.GetAttribute("year"));
					pages = int.Parse(xmlReader.GetAttribute("pages"));
					content = xmlReader.GetAttribute("content");
				}
			}
		}
		public void safeToXml(string filename) {
			StringWriter stream = new StringWriter();

			using (XmlWriter writer = XmlWriter.Create(
				stream,
				new XmlWriterSettings() { Indent = true })) {				
				writer.WriteStartDocument();
				writer.WriteStartElement("Book");
				writer.WriteAttributeString("name", name);
				writer.WriteAttributeString("author", author);
				writer.WriteAttributeString("year", year.ToString());
				writer.WriteAttributeString("pages", pages.ToString());
				writer.WriteAttributeString("content", content);
				writer.WriteEndElement();
				writer.Flush();
			}
			File.WriteAllText(filename, stream.ToString());
		}
		public void loadFromJson(string filename) {

			string json = File.ReadAllText(filename);

			using (StringReader stringReader = new StringReader(json)) {
				using (JsonTextReader reader = new JsonTextReader(stringReader)) {

					while (reader.Read()) {
						
						if (reader.Value != null) {
							Console.WriteLine(reader.Value.ToString());
							if (reader.TokenType == JsonToken.PropertyName) {
								string tokenName = reader.Value.ToString();
								switch (tokenName) {
									case "name":
									name = reader.ReadAsString();
									break;
									case "author":
									author = reader.ReadAsString();
									break;
									case "year":
									year = reader.ReadAsInt32().GetValueOrDefault(0);
									break;
									case "pages":
									pages = reader.ReadAsInt32().GetValueOrDefault(0);
									break;
									case "content":
									content = reader.ReadAsString();
									break;
									default:
									break;
								}
							}
						}
					}

				}
			}

			
		}
		public void safeToJson(string filename) {
			StringWriter stream = new StringWriter();

			using (JsonTextWriter writer = new JsonTextWriter(stream)) {
				writer.WriteStartObject();
				writer.WritePropertyName("name");
				writer.WriteValue(name);
				writer.WritePropertyName("author");
				writer.WriteValue(author);
				writer.WritePropertyName("year");
				writer.WriteValue(year);
				writer.WritePropertyName("pages");
				writer.WriteValue(pages);
				writer.WritePropertyName("content");
				writer.WriteValue(content);
				writer.WriteEndObject();
			}
			File.WriteAllText(filename, stream.ToString());
		}

		public override string ToString() {
			return "name: " + name + ", author: " + author + ", year: " + year + ", pages: " + pages + ", content: " + content;
		}
	}
}

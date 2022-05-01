using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;


string path = $"{Environment.CurrentDirectory}\\sample.pdf";
PdfReader reader = new PdfReader(path);
string text = string.Empty;
for (int page = 1; page <= reader.NumberOfPages; page++)
{
    text += PdfTextExtractor.GetTextFromPage(reader, page);
}
reader.Close();
Console.WriteLine(text);
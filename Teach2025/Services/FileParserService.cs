using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections.Generic;
using System.Windows.Documents;
using Teach2025.Models;
using Paragraph = DocumentFormat.OpenXml.Wordprocessing.Paragraph;

public class FileParserService
{
    public List<question.Question> ParseDocx(string filePath)
    {
        List<question.Question> questions = new List<question.Question>();
        using (WordprocessingDocument doc = WordprocessingDocument.Open(filePath, false))
        {
            Body body = doc.MainDocumentPart.Document.Body;
            foreach (var para in body.Elements<Paragraph>())
            {
                // Parsing logic hier
                // Voeg vragen en antwoorden toe aan de lijst
            }
        }
        return questions;
    }

    // Voeg hier een vergelijkbare methode toe voor het parsen van PDF-bestanden
}
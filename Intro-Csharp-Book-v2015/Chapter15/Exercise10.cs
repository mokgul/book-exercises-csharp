using System.Xml;

namespace Chapter15;

public static class Exercise10
{
    public static void ExtractTextFromXml(string filePath)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(filePath);

        ExtractTextNodes(doc.DocumentElement);
    }

    private static void ExtractTextNodes(XmlNode node)
    {
        if (node == null)
            return;

        foreach (XmlNode child in node.ChildNodes)
        {
            if (child.NodeType == XmlNodeType.Text)
            {
                string text = child.Value.Trim();
                if (!string.IsNullOrEmpty(text))
                {
                    Console.WriteLine(text);
                }
            }
            else
            {
                ExtractTextNodes(child);
            }
        }
    }
}
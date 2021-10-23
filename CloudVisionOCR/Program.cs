using System;
using System.Collections.Generic;
using System.IO;
using Google.Cloud.Vision.V1;    

namespace CloudVisionOCR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Image image2 = Image.FetchFromUri("https://www.nishinippon.co.jp/uploads/image/214089/large_PN2019082101001926.-.-.CI0003.jpg");
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();

            IReadOnlyList<EntityAnnotation> textAnnotations = client.DetectText(image2);
            foreach (EntityAnnotation text in textAnnotations)
            {
                Console.WriteLine($"Description: {text.Description}");
            }
        }
    }
}

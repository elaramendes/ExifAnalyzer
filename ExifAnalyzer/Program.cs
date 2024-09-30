using MetadataExtractor;

namespace ExifAnalyzer
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files(*.jpg; *jpeg; *png)|*.jpg;*.jpeg;*.png|All Files (*.*)|*.*",
                Title = "Select an image"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string imagePath = ofd.FileName;
                Console.WriteLine($"Image selected {imagePath}");

                var images = ImageMetadataReader.ReadMetadata(imagePath);

                foreach (var image in images)
                {
                    Console.WriteLine($"{image.Name}");
                    foreach (var tag in image.Tags)
                    {
                        Console.WriteLine($"{tag.Name}: {tag.Description}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Nothing selected");
            }

        }
    }
}

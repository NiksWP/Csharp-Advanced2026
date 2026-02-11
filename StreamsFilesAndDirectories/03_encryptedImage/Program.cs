var byteContents = File.ReadAllBytes(@"Files/cat-encrypted.webp");
var password = 187;

for (int i = 0; i < byteContents.Length; i++)
{
    byteContents[i] = (byte) (password ^ byteContents[i]);
}

File.WriteAllBytes(@"Files/cat-decrypted.webp", byteContents);
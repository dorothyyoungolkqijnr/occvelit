using (StreamReader reader = new StreamReader(savePath))
{
    // Read the contents of the file using the StreamReader
    string contents = reader.ReadToEnd();

    // Do something with the contents of the file
    // ...
}

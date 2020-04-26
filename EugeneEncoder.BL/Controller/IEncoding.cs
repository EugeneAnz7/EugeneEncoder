namespace EugeneEncoder.BL
{
    interface IEncodingController
    {
        string Encode(string input);
        string Decode(string input);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Carssi.Classes;
using System.Security.Cryptography;
using System.IO;

/// <summary>
/// Descripción breve de Encryptor
/// </summary>
public class Encryptor
{

    byte[] Key = new byte[] {1,2,3,4,5,6,7,8};
    byte[] Iv = new byte[] {1,2,3,4,5,6,7,8};



    public string Encrypt(string SourceData)
            {
	byte[] SourceDataBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(SourceData);
	MemoryStream TempStream = new MemoryStream();
	DESCryptoServiceProvider Encryptor = new DESCryptoServiceProvider();
	CryptoStream EncryptionStream = new CryptoStream(TempStream, Encryptor.CreateEncryptor(Key, Iv), CryptoStreamMode.Write);
	EncryptionStream.Write(SourceDataBytes, 0, SourceDataBytes.Length);
	EncryptionStream.FlushFinalBlock();
	byte[] EncryptedDataBytes = TempStream.GetBuffer();
	//MsgBox(Convert.ToBase64String(EncryptedDataBytes, 0, TempStream.Length))
	return  Convert.ToBase64String(EncryptedDataBytes,0, Convert.ToInt16(TempStream.Length));


}

    public string Decrypt(string SourceData)
    {
	    byte[] EncryptedDataBytes = Convert.FromBase64String(SourceData);
	    MemoryStream TempStream = new MemoryStream(EncryptedDataBytes, 0, EncryptedDataBytes.Length);
	    DESCryptoServiceProvider Decryptor = new DESCryptoServiceProvider();
	    CryptoStream DecryptionStream = new CryptoStream(TempStream, Decryptor.CreateDecryptor(Key, Iv), CryptoStreamMode.Read);
	    StreamReader AllDataReader = new StreamReader(DecryptionStream);
	    return AllDataReader.ReadToEnd();
    }
}

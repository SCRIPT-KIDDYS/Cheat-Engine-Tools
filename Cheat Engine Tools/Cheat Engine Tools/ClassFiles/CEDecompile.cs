#region Using
using System;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
#endregion

internal class CEDecompile
{
    #region DecryptTrainer


    public static bool DecryptTrainer(string filePath)
    {
        MemoryStream ms;
        BinaryReader br;

        string outFileName = "Decrypted_" + Path.GetFileName(filePath);
        string outFilePath = Path.Combine(Path.GetDirectoryName(filePath), outFileName);

        byte[] raw_data = File.ReadAllBytes(filePath);
        int size = raw_data.Length;
        byte ckey = 0xCE;

        for (int i = 2; i < size; i++)
        {
            raw_data[i] = (byte)(raw_data[i] ^ raw_data[i - 2]);
        }

        for (int j = size - 2; j >= 0; j--)
        {
            raw_data[j] = (byte)(raw_data[j] ^ raw_data[j + 1]);
        }

        for (int k = 0; k < size; k++)
        {
            raw_data[k] = (byte)(raw_data[k] ^ ckey);
            ++ckey;
        }

        ms = new MemoryStream(raw_data);
        br = new BinaryReader(ms);

        byte[] CE_MAGIC = br.ReadBytes(5);
        if (Encoding.ASCII.GetString(CE_MAGIC) == "CHEAT")
        {
            ms.Seek(5, SeekOrigin.Begin);
            byte[] out_data = DeCompress(br.ReadBytes((int)ms.Length - 5));
            if (out_data.Length == 0)
            {
                MessageBox.Show("Failed to decompress!");
                return false;
            }
            byte[] out_dataFinal = new byte[out_data.Length - 4];
            Array.Copy(out_data, 4, out_dataFinal, 0, out_dataFinal.Length);
            File.WriteAllBytes(outFilePath, out_dataFinal);
            return true;
        }
        else
        {
            MessageBox.Show(
                "Something went wrong. Here could be the reasons" + Environment.NewLine + 
                "1: Trainer is not encrypted." + Environment.NewLine + 
                "2: Trainer decryption went wrong" + Environment.NewLine + 
                "3: Trainer is using the new encryption method.", 
                "ERROR");

            return false;
        }

    }
    #endregion

    #region DeCompress
    private static byte[] DeCompress(byte[] data)
    {
        using (var compressStream = new MemoryStream(data))
        using (var outStream = new MemoryStream())
        using (var compressor = new DeflateStream(compressStream, CompressionMode.Decompress))
        {
            compressor.CopyTo(outStream);
            compressor.Close();
            return outStream.ToArray();
        }
    }
    #endregion
}

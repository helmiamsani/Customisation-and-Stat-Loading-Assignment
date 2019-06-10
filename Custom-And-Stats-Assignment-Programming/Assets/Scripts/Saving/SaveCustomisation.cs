using System.IO;
using System.Runtime.Serialization.Formatters.Binary; // formatting this shit to binary
using UnityEngine;

public static class SaveCustomisation
{
    public static void SavePlayerCustomisation(Customisation custom)
    {
        // reference to binary formatter (this changing the code into binary language)
        BinaryFormatter formatter = new BinaryFormatter();

        // path to save to "/save.rar" file
        string path = Application.persistentDataPath + "/Save.jpg";

        // file stream create file at path
        FileStream stream = new FileStream(path, FileMode.Create);

        // dataToSave with player info
        SavedDataCustomisation data = new SavedDataCustomisation(custom);

        // format and serialize location and data 
        formatter.Serialize(stream, data);

        // end
        stream.Close();
    }

    public static SavedDataCustomisation LoadPlayerData()
    {
        // File is existed
        string path = Application.persistentDataPath + "/Save.jpg";
        if (File.Exists(path))
        {
            // reference to binary formatter (this changing the code into binary language)
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            SavedDataCustomisation data = formatter.Deserialize(stream) as SavedDataCustomisation;
            stream.Close();
            return data;

        }
        else
        {
            Debug.Log("Error");
            return null;
        }
    }
}


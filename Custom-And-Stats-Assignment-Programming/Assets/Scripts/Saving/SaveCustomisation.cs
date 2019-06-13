using System.IO;
using System.Runtime.Serialization.Formatters.Binary; // formatting this shit to binary
using UnityEngine;

public static class SaveCustomisation
{
    #region Save
    public static void SavePlayerCustomisation(Customisation custom)
    {
        // reference to binary formatter (this changing the code into binary language)
        BinaryFormatter formatter = new BinaryFormatter();

        // path to save to "/Save.jpg" file
        string path = Application.persistentDataPath + "/Save.jpg";

        // file stream create file at path
        FileStream stream = new FileStream(path, FileMode.Create);

        // SavedData with player info
        SavedData data = new SavedData(custom);

        // format and serialize location and data 
        formatter.Serialize(stream, data);

        // end
        stream.Close();
    }
    #endregion

    #region Load
    public static SavedData LoadPlayerData()
    {
        // File is existed
        string path = Application.persistentDataPath + "/Save.jpg";
        if (File.Exists(path))
        {
            // reference to binary formatter (this changing the code into binary language)
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            SavedData data = formatter.Deserialize(stream) as SavedData;
            stream.Close();
            return data;

        }
        else
        {
            Debug.Log("Error");
            return null;
        }
    }
    #endregion
}


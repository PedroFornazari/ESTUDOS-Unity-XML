using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public class GameXML : MonoBehaviour
{
    public GameObject Player;
    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Item4;
    public GameObject Item5;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void salvar()
    {
        Banco bd = new Banco();
        if (bd.inserir(Player.gameObject))
        {
            print("Salvo com sucesso!");
        }
        else
        {
            print("Erro ao salvar!");
        }
    }

    public void carregar()
    {
        Banco bd = new Banco();
        if (bd.alterar(Player.gameObject, Item1.gameObject, Item2.gameObject, Item3.gameObject, Item4.gameObject, Item5.gameObject))
        {
            print("Alterado com sucesso!");
        }
        else
        {
            print("Erro ao alterar!");
        }
    }

    /*
    public void salvar()
    {
        string filepath = Path.Combine(Application.streamingAssetsPath, "save.xml");
        Save save = new Save();
        save.posx = Player.transform.position.x;
        save.posy = Player.transform.position.y;
        save.posz = Player.transform.position.z;
        save.rotx = Player.transform.rotation.x;
        save.roty = Player.transform.rotation.y;
        save.rotz = Player.transform.rotation.z;
        save.timing = Tempo.tempoJogo;

        if (Item1 != null)
        {
            save.item1x = Item1.transform.position.x;
            save.item1y = Item1.transform.position.y;
            save.item1z = Item1.transform.position.z;
        }

        if (Item2 != null)
        {
            save.item2x = Item2.transform.position.x;
            save.item2y = Item2.transform.position.y;
            save.item2z = Item2.transform.position.z;
        }

        if (Item3 != null)
        {
            save.item3x = Item3.transform.position.x;
            save.item3y = Item3.transform.position.y;
            save.item3z = Item3.transform.position.z;
        }

        if (Item4 != null)
        {
            save.item4x = Item4.transform.position.x;
            save.item4y = Item4.transform.position.y;
            save.item4z = Item4.transform.position.z;
        }

        if (Item5 != null)
        {
            save.item5x = Item5.transform.position.x;
            save.item5y = Item5.transform.position.y;
            save.item5z = Item5.transform.position.z;
        }


        if (!Directory.Exists(Application.streamingAssetsPath))
        {
            Directory.CreateDirectory(Application.streamingAssetsPath);
        }

        XmlSerializer xml = new XmlSerializer(typeof(Save));
        StreamWriter escrita = new StreamWriter(filepath);

        xml.Serialize(escrita.BaseStream, save);

        escrita.Close();

    }

    public void carregar()
    {
        string filepath = Path.Combine(Application.streamingAssetsPath, "save.xml");

        XmlSerializer xml = new XmlSerializer(typeof(Save));
        StreamReader leitor = new StreamReader(filepath);
        Save save = (Save)xml.Deserialize(leitor.BaseStream);
        leitor.Close();

        Player.transform.position = new Vector3(save.posx, save.posy, save.posz);
        Player.transform.localEulerAngles = new Vector3(save.rotx, save.roty, save.rotz);
        Tempo.tempoJogo = save.timing;

        if(save.item1x != 0 && save.item1y != 0 && save.item1z != 0)
        {
            Item1.transform.position = new Vector3(save.item1x, save.item1y, save.item1z);
        }
        else
        {
            Destroy(Item1);
        }

        if (save.item2x != 0 && save.item2y != 0 && save.item2z != 0)
        {
            Item1.transform.position = new Vector3(save.item2x, save.item2y, save.item2z);
        }
        else
        {
            Destroy(Item2);
        }

        if (save.item3x != 0 && save.item3y != 0 && save.item3z != 0)
        {
            Item1.transform.position = new Vector3(save.item3x, save.item3y, save.item3z);
        }
        else
        {
            Destroy(Item3);
        }

        if (save.item4x != 0 && save.item4y != 0 && save.item4z != 0)
        {
            Item1.transform.position = new Vector3(save.item4x, save.item4y, save.item4z);
        }
        else
        {
            Destroy(Item4);
        }

        if (save.item5x != 0 && save.item5y != 0 && save.item5z != 0)
        {
            Item1.transform.position = new Vector3(save.item5x, save.item5y, save.item5z);
        }
        else
        {
            Destroy(Item5);
        }
    }
    */
}

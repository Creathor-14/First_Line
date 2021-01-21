using net.TBMSP.Lib.File;
using net.TBMSP.Lib.TBMPk.File;
using UnityEngine;

public class Manager:MonoBehaviour{
    public Transform player,LoadMenu,SaveMenu;
    private static string[] Slots=new string[4];
    private static Transform p; 
    public static Manager GetComponent()
    {
    return p.GetComponent<Manager>();
    }
    void Awake()
    {
        p=this.transform;
        net.TBMSP.Lib.Program.Init(Application.persistentDataPath+"/",true);
        Debug.Log("En esta carpeta se guardan los archivos: \""+net.TBMSP.Lib.Program.RootDirectory+"\""); 
        FileBase.CreateDirectory("Data/SaveData");
        for(int i=0;i<Slots.Length;i++){
        Slots[i]=TDF.CreateString(); }
}
    void Start()
    {
        player.GetComponent<PlayerMove>().Move=false;
        SaveMenu.gameObject.SetActive(false);
        LoadMenu.gameObject.SetActive(true);
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.Z)){
        player.GetComponent<PlayerMove>().Move=false;
        SaveMenu.gameObject.SetActive(false);
        LoadMenu.gameObject.SetActive(true);
    }
    }
public void saveGame(int SlotID){
SaveGame(SlotID);
SaveMenu.gameObject.SetActive(false);
player.GetComponent<PlayerMove>().Move=true;
}
public void loadGame(int SlotID){
if(FileBase.FileExist("Data/SaveData/Slot_"+(SlotID+1)+".tdf")){
Slots[SlotID]=TDF.Load("Data/SaveData/Slot_"+(SlotID+1)+".tdf");//TDF.LoadGZ
var playerComp=GetComponent().player.GetComponent<PlayerMove>();
var pos=TDF.GetValueOfBlock(Slots[SlotID],"Game", "PlayerPos").Split(","[0]);
var posX=float.Parse(pos[0]);
var posY=float.Parse(pos[1]);

player.position=new Vector2(posX,posY);

}
player.GetComponent<PlayerMove>().Move=true;
SaveMenu.gameObject.SetActive(false);
LoadMenu.gameObject.SetActive(false);
}
public static void OpenSaveMenu(){
GetComponent().SaveMenu.gameObject.SetActive(true);
GetComponent().LoadMenu.gameObject.SetActive(false);
GetComponent().player.GetComponent<PlayerMove>().Move=false;
}
public static void SaveGame(int SlotID)
{
    Slots[SlotID]=TDF.SaveValueInBlock(Slots[SlotID],"Game","PlayerPos",GetComponent().player.position.x+","+GetComponent().player.position.y+","+GetComponent().player.position.z);
    TDF.Save("Data/SaveData/Slot_"+(SlotID+1)+".tdf",Slots[SlotID]);//TDF.SaveGZ
}
}

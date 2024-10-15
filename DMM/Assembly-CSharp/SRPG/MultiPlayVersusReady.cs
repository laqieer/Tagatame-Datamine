// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayVersusReady
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002795")]
  [AddComponentMenu("UI/MultiPlayVersusReady")]
  public class MultiPlayVersusReady : MonoBehaviour
  {
    [Token(Token = "0x400BAF5")]
    [FieldOffset(Offset = "0xC")]
    public TargetPlate TargetTemplate;
    [Token(Token = "0x400BAF6")]
    [FieldOffset(Offset = "0x10")]
    public TargetPlate TargetObjTemplate;
    [Token(Token = "0x400BAF7")]
    [FieldOffset(Offset = "0x14")]
    public TargetPlate TargetTrickTemplate;
    [Token(Token = "0x400BAF8")]
    [FieldOffset(Offset = "0x18")]
    public GameObject TargetParent;
    [Token(Token = "0x400BAF9")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject TargetMarker;
    [Token(Token = "0x400BAFA")]
    [FieldOffset(Offset = "0x20")]
    public Button CameraRotateL;
    [Token(Token = "0x400BAFB")]
    [FieldOffset(Offset = "0x24")]
    public Button CameraRotateR;
    [Token(Token = "0x400BAFC")]
    [FieldOffset(Offset = "0x28")]
    public TouchController TouchController;
    [Token(Token = "0x400BAFD")]
    [FieldOffset(Offset = "0x2C")]
    public Button GoButton;
    [Token(Token = "0x400BAFE")]
    [FieldOffset(Offset = "0x30")]
    public GameObject QuestObj;
    [Token(Token = "0x400BAFF")]
    [FieldOffset(Offset = "0x34")]
    public bool TowerMode;
    [Token(Token = "0x400BB00")]
    [FieldOffset(Offset = "0x35")]
    public bool RankMatchMode;
    [Token(Token = "0x400BB01")]
    [FieldOffset(Offset = "0x36")]
    public bool DraftMode;
    [Token(Token = "0x400BB02")]
    [FieldOffset(Offset = "0x37")]
    private bool m_Ready;
    [Token(Token = "0x400BB03")]
    [FieldOffset(Offset = "0x38")]
    private bool m_SyncLoad;
    [Token(Token = "0x400BB04")]
    [FieldOffset(Offset = "0x3C")]
    private QuestParam m_CurrentQuest;
    [Token(Token = "0x400BB05")]
    [FieldOffset(Offset = "0x40")]
    private Vector3 m_CameraPos;
    [Token(Token = "0x400BB06")]
    [FieldOffset(Offset = "0x4C")]
    private Vector3 m_CameraRot;
    [Token(Token = "0x400BB07")]
    [FieldOffset(Offset = "0x58")]
    private Vector3 m_CameraNextPos;
    [Token(Token = "0x400BB08")]
    [FieldOffset(Offset = "0x64")]
    private int m_SelectParty;
    [Token(Token = "0x400BB09")]
    [FieldOffset(Offset = "0x68")]
    private List<TacticsUnitController> m_Units;
    [Token(Token = "0x400BB0A")]
    [FieldOffset(Offset = "0x6C")]
    private TacticsSceneSettings m_SceneRoot;
    [Token(Token = "0x400BB0B")]
    [FieldOffset(Offset = "0x70")]
    private TargetPlate m_Status;
    [Token(Token = "0x400BB0C")]
    [FieldOffset(Offset = "0x74")]
    private TargetPlate m_StatusObj;
    [Token(Token = "0x400BB0D")]
    [FieldOffset(Offset = "0x78")]
    private TargetPlate m_StatusTrick;
    [Token(Token = "0x400BB0E")]
    [FieldOffset(Offset = "0x7C")]
    private List<BattleMap> m_Map;
    [Token(Token = "0x400BB0F")]
    [FieldOffset(Offset = "0x80")]
    private TargetCamera m_Camera;
    [Token(Token = "0x400BB10")]
    [FieldOffset(Offset = "0x84")]
    private readonly float CAM_ROTATE_TIME;
    [Token(Token = "0x400BB11")]
    [FieldOffset(Offset = "0x88")]
    private readonly float CAM_ROTATE_VAL;
    [Token(Token = "0x400BB12")]
    [FieldOffset(Offset = "0x8C")]
    private float m_CamAngle;
    [Token(Token = "0x400BB13")]
    [FieldOffset(Offset = "0x90")]
    private float m_CamAngleStart;
    [Token(Token = "0x400BB14")]
    [FieldOffset(Offset = "0x94")]
    private float m_CamAngleGoal;
    [Token(Token = "0x400BB15")]
    [FieldOffset(Offset = "0x98")]
    private float m_CamRotateTime;
    [Token(Token = "0x400BB16")]
    [FieldOffset(Offset = "0x9C")]
    private float m_CamYawMin;
    [Token(Token = "0x400BB17")]
    [FieldOffset(Offset = "0xA0")]
    private float m_CamYawMax;
    [Token(Token = "0x400BB18")]
    [FieldOffset(Offset = "0xA4")]
    private bool m_CamMove;
    [Token(Token = "0x400BB19")]
    [FieldOffset(Offset = "0xA8")]
    private IntVector2 m_SelectGrid;
    [Token(Token = "0x400BB1A")]
    [FieldOffset(Offset = "0xB0")]
    private GameObject m_Marker;
    [Token(Token = "0x400BB1B")]
    [FieldOffset(Offset = "0xB4")]
    private GameObject m_TrickMarkerObj;
    [Token(Token = "0x400BB1C")]
    [FieldOffset(Offset = "0xB8")]
    private Dictionary<string, GameObject> m_TrickMarkers;
    [Token(Token = "0x400BB1D")]
    [FieldOffset(Offset = "0xBC")]
    private List<PhotonPlayerParameter> m_Players;
    [Token(Token = "0x400BB1E")]
    [FieldOffset(Offset = "0x0")]
    private static MultiPlayVersusReady m_Instance;
    [Token(Token = "0x400BB1F")]
    [FieldOffset(Offset = "0xC0")]
    private bool isUpdate;

    [Token(Token = "0x17001885")]
    public bool IsReady
    {
      [Token(Token = "0x600B198"), Address(RVA = "0x761750", Offset = "0x760550", VA = "0x10761750")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001886")]
    private BattleMap CurrentMap
    {
      [Token(Token = "0x600B199"), Address(RVA = "0x7616C0", Offset = "0x7604C0", VA = "0x107616C0")] get
      {
        return (BattleMap) null;
      }
    }

    [Token(Token = "0x17001887")]
    public static MultiPlayVersusReady Instance
    {
      [Token(Token = "0x600B19A"), Address(RVA = "0x761720", Offset = "0x760520", VA = "0x10761720")] get
      {
        return (MultiPlayVersusReady) null;
      }
    }

    [Token(Token = "0x600B19B")]
    [Address(RVA = "0x75E750", Offset = "0x75D550", VA = "0x1075E750")]
    private void Start()
    {
    }

    [Token(Token = "0x600B19C")]
    [Address(RVA = "0x75BFD0", Offset = "0x75ADD0", VA = "0x1075BFD0")]
    private void InitCamera()
    {
    }

    [Token(Token = "0x600B19D")]
    [Address(RVA = "0x75C4D0", Offset = "0x75B2D0", VA = "0x1075C4D0")]
    private void InitStatusWindow()
    {
    }

    [Token(Token = "0x600B19E")]
    [Address(RVA = "0x75CAD0", Offset = "0x75B8D0", VA = "0x1075CAD0")]
    private void InitTouchArea()
    {
    }

    [Token(Token = "0x600B19F")]
    [Address(RVA = "0x75C3E0", Offset = "0x75B1E0", VA = "0x1075C3E0")]
    private void InitMap()
    {
    }

    [Token(Token = "0x600B1A0")]
    [Address(RVA = "0x75C950", Offset = "0x75B750", VA = "0x1075C950")]
    private void InitTargetMarker()
    {
    }

    [Token(Token = "0x600B1A1")]
    [Address(RVA = "0x75CD00", Offset = "0x75BB00", VA = "0x1075CD00")]
    private List<Unit> LoadMultiTower() => (List<Unit>) null;

    [Token(Token = "0x600B1A2")]
    [Address(RVA = "0x75BA50", Offset = "0x75A850", VA = "0x1075BA50")]
    private List<UnitData> GetMultiTowerPlayersUnitData() => (List<UnitData>) null;

    [Token(Token = "0x600B1A3")]
    [Address(RVA = "0x75D660", Offset = "0x75C460", VA = "0x1075D660")]
    private List<Unit> LoadRankMatchParty() => (List<Unit>) null;

    [Token(Token = "0x600B1A4")]
    [Address(RVA = "0x75BDD0", Offset = "0x75ABD0", VA = "0x1075BDD0")]
    private List<UnitData> GetRankMatchPlayersUnitData() => (List<UnitData>) null;

    [Token(Token = "0x600B1A5")]
    [Address(RVA = "0x75D760", Offset = "0x75C560", VA = "0x1075D760")]
    private List<Unit> LoadVersusDraftParty() => (List<Unit>) null;

    [Token(Token = "0x600B1A6")]
    [Address(RVA = "0x75D970", Offset = "0x75C770", VA = "0x1075D970")]
    private List<Unit> LoadVersusParty() => (List<Unit>) null;

    [Token(Token = "0x600B1A7")]
    [Address(RVA = "0x75BED0", Offset = "0x75ACD0", VA = "0x1075BED0")]
    private List<UnitData> GetVersusPlayersUnitData() => (List<UnitData>) null;

    [Token(Token = "0x600B1A8")]
    [Address(RVA = "0x75ADE0", Offset = "0x759BE0", VA = "0x1075ADE0")]
    private IEnumerator ConfirmDownloadAsync(Action onDownloadPopTimeout) => (IEnumerator) null;

    [Token(Token = "0x600B1A9")]
    [Address(RVA = "0x75D680", Offset = "0x75C480", VA = "0x1075D680")]
    private IEnumerator LoadSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x600B1AA")]
    [Address(RVA = "0x75D260", Offset = "0x75C060", VA = "0x1075D260")]
    private List<Unit> LoadPartyUnit(PlayerPartyTypes partyType) => (List<Unit>) null;

    [Token(Token = "0x600B1AB")]
    [Address(RVA = "0x761490", Offset = "0x760290", VA = "0x10761490")]
    private void Update()
    {
    }

    [Token(Token = "0x600B1AC")]
    [Address(RVA = "0x760900", Offset = "0x75F700", VA = "0x10760900")]
    private void UpdatePlayer(PhotonPlayerParameter playerParam)
    {
    }

    [Token(Token = "0x600B1AD")]
    [Address(RVA = "0x75F650", Offset = "0x75E450", VA = "0x1075F650")]
    private void UpdateCamera()
    {
    }

    [Token(Token = "0x600B1AE")]
    [Address(RVA = "0x75F570", Offset = "0x75E370", VA = "0x1075F570")]
    private void UpdateCameraRotate()
    {
    }

    [Token(Token = "0x600B1AF")]
    [Address(RVA = "0x75F3C0", Offset = "0x75E1C0", VA = "0x1075F3C0")]
    private void UpdateCameraPosition()
    {
    }

    [Token(Token = "0x600B1B0")]
    [Address(RVA = "0x75EC70", Offset = "0x75DA70", VA = "0x1075EC70")]
    private void SyncRoomPlayer()
    {
    }

    [Token(Token = "0x600B1B1")]
    [Address(RVA = "0x75D6F0", Offset = "0x75C4F0", VA = "0x1075D6F0")]
    private IEnumerator LoadUnit() => (IEnumerator) null;

    [Token(Token = "0x600B1B2")]
    [Address(RVA = "0x75E0A0", Offset = "0x75CEA0", VA = "0x1075E0A0")]
    private void OnLoadScene(GameObject go)
    {
    }

    [Token(Token = "0x600B1B3")]
    [Address(RVA = "0x75DF10", Offset = "0x75CD10", VA = "0x1075DF10")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B1B4")]
    [Address(RVA = "0x760F40", Offset = "0x75FD40", VA = "0x10760F40")]
    private void UpdateUnitStatus(int add, bool lerp = false)
    {
    }

    [Token(Token = "0x600B1B5")]
    [Address(RVA = "0x75ADB0", Offset = "0x759BB0", VA = "0x1075ADB0")]
    private void CloseUnitStatus()
    {
    }

    [Token(Token = "0x600B1B6")]
    [Address(RVA = "0x75E1F0", Offset = "0x75CFF0", VA = "0x1075E1F0")]
    private void OnNextUnit(GameObject obj)
    {
    }

    [Token(Token = "0x600B1B7")]
    [Address(RVA = "0x75E270", Offset = "0x75D070", VA = "0x1075E270")]
    private void OnPrevUnit(GameObject obj)
    {
    }

    [Token(Token = "0x600B1B8")]
    [Address(RVA = "0x75E2F0", Offset = "0x75D0F0", VA = "0x1075E2F0")]
    private void OnTouchClick(Vector2 screenPos)
    {
    }

    [Token(Token = "0x600B1B9")]
    [Address(RVA = "0x75ACA0", Offset = "0x759AA0", VA = "0x1075ACA0")]
    private List<int> CheckExistUnit(int x, int y) => (List<int>) null;

    [Token(Token = "0x600B1BA")]
    [Address(RVA = "0x760910", Offset = "0x75F710", VA = "0x10760910")]
    private void UpdateSelectGrid()
    {
    }

    [Token(Token = "0x600B1BB")]
    [Address(RVA = "0x75ABE0", Offset = "0x7599E0", VA = "0x1075ABE0")]
    private void CalcPosition(TacticsUnitController controller)
    {
    }

    [Token(Token = "0x600B1BC")]
    [Address(RVA = "0x7606F0", Offset = "0x75F4F0", VA = "0x107606F0")]
    private void UpdateMarker(TacticsUnitController controller = null)
    {
    }

    [Token(Token = "0x600B1BD")]
    [Address(RVA = "0x75D990", Offset = "0x75C790", VA = "0x1075D990")]
    private void OnCameraRotateL()
    {
    }

    [Token(Token = "0x600B1BE")]
    [Address(RVA = "0x75D9E0", Offset = "0x75C7E0", VA = "0x1075D9E0")]
    private void OnCameraRotateR()
    {
    }

    [Token(Token = "0x600B1BF")]
    [Address(RVA = "0x75BBE0", Offset = "0x75A9E0", VA = "0x1075BBE0")]
    private int GetPlacementID(int x, int y) => new int();

    [Token(Token = "0x600B1C0")]
    [Address(RVA = "0x75CB80", Offset = "0x75B980", VA = "0x1075CB80")]
    private bool IsSamePosition() => new bool();

    [Token(Token = "0x600B1C1")]
    [Address(RVA = "0x75DA30", Offset = "0x75C830", VA = "0x1075DA30")]
    private void OnClickGo()
    {
    }

    [Token(Token = "0x600B1C2")]
    [Address(RVA = "0x75E460", Offset = "0x75D260", VA = "0x1075E460")]
    private void SendPlacementInfo()
    {
    }

    [Token(Token = "0x600B1C3")]
    [Address(RVA = "0x75FCD0", Offset = "0x75EAD0", VA = "0x1075FCD0")]
    private void UpdateGridColor()
    {
    }

    [Token(Token = "0x600B1C4")]
    [Address(RVA = "0x75B7B0", Offset = "0x75A5B0", VA = "0x1075B7B0")]
    public int GetDisplayHeight(Unit unit) => new int();

    [Token(Token = "0x600B1C5")]
    [Address(RVA = "0x75AAB0", Offset = "0x7598B0", VA = "0x1075AAB0")]
    public IntVector2 CalcCoord(Vector3 position) => new IntVector2();

    [Token(Token = "0x600B1C6")]
    [Address(RVA = "0x75B4C0", Offset = "0x75A2C0", VA = "0x1075B4C0")]
    private string DebugSearchPos(int x, int y) => (string) null;

    [Token(Token = "0x600B1C7")]
    [Address(RVA = "0x75AE50", Offset = "0x759C50", VA = "0x1075AE50")]
    private void DebugPlacement(GameObject go)
    {
    }

    [Token(Token = "0x600B1C8")]
    [Address(RVA = "0x7614E0", Offset = "0x7602E0", VA = "0x107614E0")]
    public MultiPlayVersusReady()
    {
    }
  }
}

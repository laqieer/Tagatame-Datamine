// Decompiled with JetBrains decompiler
// Type: SRPG.UnitMapPlacement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002CC2")]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(102, "配置重複エラー", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "Decide完了", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/UnitMapPlacement")]
  [FlowNode.Pin(11, "CameraLeft", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "Decide", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(12, "CameraRight", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  public class UnitMapPlacement : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400DE55")]
    public const string SVB_KEY_PARTY_UNITS = "SVB_KEY_PARTY_UNITS";
    [Token(Token = "0x400DE56")]
    public const string SVB_KEY_ENEMY_UNITS = "SVB_KEY_ENEMY_UNITS";
    [Token(Token = "0x400DE57")]
    public const string SVB_KEY_IS_ENEMY_SIDE_EDIT = "SVB_KEY_IS_ENEMY_SIDE_EDIT";
    [Token(Token = "0x400DE58")]
    public const float FADE_IN_TIME = 1f;
    [Token(Token = "0x400DE59")]
    public const int MAP_SETTING_MAX_NUM = 99;
    [Token(Token = "0x400DE5A")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400DE5B")]
    private const int PIN_IN_BTN_DECIDE = 10;
    [Token(Token = "0x400DE5C")]
    private const int PIN_IN_BTN_CAMERA_LEFT = 11;
    [Token(Token = "0x400DE5D")]
    private const int PIN_IN_BTN_CAMERA_RIGHT = 12;
    [Token(Token = "0x400DE5E")]
    private const int PIN_OUTPUT_DECIDE = 101;
    [Token(Token = "0x400DE5F")]
    private const int PIN_OUTPUT_SAME_POSITION = 102;
    [Token(Token = "0x400DE60")]
    private const int PIN_OUTPUT_ERROR = 1001;
    [Token(Token = "0x400DE61")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform TargetParent;
    [Token(Token = "0x400DE62")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private TargetPlate TargetTemplate;
    [Token(Token = "0x400DE63")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject TargetMarker;
    [Token(Token = "0x400DE64")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TouchController mTouchController;
    [Token(Token = "0x400DE65")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400DE66")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400DE67")]
    [FieldOffset(Offset = "0x24")]
    private QuestParam mCurrentQuest;
    [Token(Token = "0x400DE68")]
    [FieldOffset(Offset = "0x28")]
    private List<BattleMap> mMap;
    [Token(Token = "0x400DE69")]
    [FieldOffset(Offset = "0x2C")]
    private List<TacticsUnitController> mUnits;
    [Token(Token = "0x400DE6A")]
    [FieldOffset(Offset = "0x30")]
    private TacticsSceneSettings m_SceneRoot;
    [Token(Token = "0x400DE6B")]
    [FieldOffset(Offset = "0x34")]
    private int mSelectPartyIndex;
    [Token(Token = "0x400DE6C")]
    [FieldOffset(Offset = "0x38")]
    private TargetPlate mStatus;
    [Token(Token = "0x400DE6D")]
    [FieldOffset(Offset = "0x3C")]
    private UnitMapPlacementModel mModels;
    [Token(Token = "0x400DE6E")]
    [FieldOffset(Offset = "0x40")]
    private List<UnitMapPlacement.UnitPlaceData> mPlacementUnits;
    [Token(Token = "0x400DE6F")]
    [FieldOffset(Offset = "0x44")]
    private List<UnitMapPlacement.UnitPlaceData> mEnemyUnits;
    [Token(Token = "0x400DE70")]
    [FieldOffset(Offset = "0x48")]
    private bool mIsDecide;
    [Token(Token = "0x400DE71")]
    [FieldOffset(Offset = "0x4C")]
    private TargetCamera mCamera;
    [Token(Token = "0x400DE72")]
    [FieldOffset(Offset = "0x50")]
    private Vector3 mCameraPos;
    [Token(Token = "0x400DE73")]
    [FieldOffset(Offset = "0x5C")]
    private Vector3 mCameraRot;
    [Token(Token = "0x400DE74")]
    [FieldOffset(Offset = "0x68")]
    private Vector3 mCameraNextPos;
    [Token(Token = "0x400DE75")]
    [FieldOffset(Offset = "0x74")]
    private readonly float CAM_ROTATE_TIME;
    [Token(Token = "0x400DE76")]
    [FieldOffset(Offset = "0x78")]
    private readonly float CAM_ROTATE_VAL;
    [Token(Token = "0x400DE77")]
    [FieldOffset(Offset = "0x7C")]
    private float m_CamAngle;
    [Token(Token = "0x400DE78")]
    [FieldOffset(Offset = "0x80")]
    private float m_CamAngleStart;
    [Token(Token = "0x400DE79")]
    [FieldOffset(Offset = "0x84")]
    private float m_CamAngleGoal;
    [Token(Token = "0x400DE7A")]
    [FieldOffset(Offset = "0x88")]
    private float m_CamRotateTime;
    [Token(Token = "0x400DE7B")]
    [FieldOffset(Offset = "0x8C")]
    private bool m_CamMove;
    [Token(Token = "0x400DE7C")]
    [FieldOffset(Offset = "0x90")]
    private IntVector2 mSelectGrid;
    [Token(Token = "0x400DE7D")]
    [FieldOffset(Offset = "0x98")]
    private bool mIsEnemySideEdit;
    [Token(Token = "0x400DE7E")]
    [FieldOffset(Offset = "0x9C")]
    private List<UnitSetting> mPlayerUnitSettings;
    [Token(Token = "0x400DE7F")]
    [FieldOffset(Offset = "0xA0")]
    private List<UnitSetting> mEnemyUnitSettings;
    [Token(Token = "0x400DE80")]
    [FieldOffset(Offset = "0xA4")]
    private GameObject mMarker;
    [Token(Token = "0x400DE81")]
    [FieldOffset(Offset = "0xA8")]
    private GameObject mTrickMarkerObj;
    [Token(Token = "0x400DE82")]
    [FieldOffset(Offset = "0xAC")]
    private Dictionary<string, GameObject> mTrickMarkers;
    [Token(Token = "0x400DE83")]
    [FieldOffset(Offset = "0x0")]
    private static UnitMapPlacement mInstance;

    [Token(Token = "0x17001B66")]
    public static UnitMapPlacement Instance
    {
      [Token(Token = "0x600D00C"), Address(RVA = "0x9B4270", Offset = "0x9B3070", VA = "0x109B4270")] get
      {
        return (UnitMapPlacement) null;
      }
    }

    [Token(Token = "0x17001B67")]
    private BattleMap CurrentMap
    {
      [Token(Token = "0x600D00D"), Address(RVA = "0x9B4230", Offset = "0x9B3030", VA = "0x109B4230")] get
      {
        return (BattleMap) null;
      }
    }

    [Token(Token = "0x600D00E")]
    [Address(RVA = "0x9AFEB0", Offset = "0x9AECB0", VA = "0x109AFEB0")]
    public static List<UnitMapPlacement.UnitPlaceData> CreateUnitMapPlaceData(
      List<UnitData> units,
      JSON_LeagueMatchSet[] place_data,
      int placement_max = 99)
    {
      return (List<UnitMapPlacement.UnitPlaceData>) null;
    }

    [Token(Token = "0x600D00F")]
    [Address(RVA = "0x9B0380", Offset = "0x9AF180", VA = "0x109B0380")]
    public static int GetMapArenaSettingMax(string quest_iname) => new int();

    [Token(Token = "0x600D010")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600D011")]
    [Address(RVA = "0x9AFC60", Offset = "0x9AEA60", VA = "0x109AFC60", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D012")]
    [Address(RVA = "0x9AFD00", Offset = "0x9AEB00", VA = "0x109AFD00")]
    private void Awake()
    {
    }

    [Token(Token = "0x600D013")]
    [Address(RVA = "0x9B18C0", Offset = "0x9B06C0", VA = "0x109B18C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600D014")]
    [Address(RVA = "0x9B4040", Offset = "0x9B2E40", VA = "0x109B4040")]
    private void Update()
    {
    }

    [Token(Token = "0x600D015")]
    [Address(RVA = "0x9B0EE0", Offset = "0x9AFCE0", VA = "0x109B0EE0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600D016")]
    [Address(RVA = "0x9B0E30", Offset = "0x9AFC30", VA = "0x109B0E30")]
    private void InitTouchArea()
    {
    }

    [Token(Token = "0x600D017")]
    [Address(RVA = "0x9B0940", Offset = "0x9AF740", VA = "0x109B0940")]
    private void InitMap()
    {
    }

    [Token(Token = "0x600D018")]
    [Address(RVA = "0x9B0B00", Offset = "0x9AF900", VA = "0x109B0B00")]
    private void InitStatusWindow()
    {
    }

    [Token(Token = "0x600D019")]
    [Address(RVA = "0x9B0CB0", Offset = "0x9AFAB0", VA = "0x109B0CB0")]
    private void InitTargetMarker()
    {
    }

    [Token(Token = "0x600D01A")]
    [Address(RVA = "0x9B1DC0", Offset = "0x9B0BC0", VA = "0x109B1DC0")]
    private void OnNextUnit(GameObject go)
    {
    }

    [Token(Token = "0x600D01B")]
    [Address(RVA = "0x9B1DE0", Offset = "0x9B0BE0", VA = "0x109B1DE0")]
    private void OnPrevUnit(GameObject go)
    {
    }

    [Token(Token = "0x600D01C")]
    [Address(RVA = "0x9B15F0", Offset = "0x9B03F0", VA = "0x109B15F0")]
    private void OnCameraRotateL()
    {
    }

    [Token(Token = "0x600D01D")]
    [Address(RVA = "0x9B1640", Offset = "0x9B0440", VA = "0x109B1640")]
    private void OnCameraRotateR()
    {
    }

    [Token(Token = "0x600D01E")]
    [Address(RVA = "0x9B1E00", Offset = "0x9B0C00", VA = "0x109B1E00")]
    private void OnTouchClick(Vector2 screenPos)
    {
    }

    [Token(Token = "0x600D01F")]
    [Address(RVA = "0x9B1690", Offset = "0x9B0490", VA = "0x109B1690")]
    private void OnClickDecide()
    {
    }

    [Token(Token = "0x600D020")]
    [Address(RVA = "0x9B0600", Offset = "0x9AF400", VA = "0x109B0600")]
    private void InitCamera()
    {
    }

    [Token(Token = "0x600D021")]
    [Address(RVA = "0x9B2210", Offset = "0x9B1010", VA = "0x109B2210")]
    private void UpdateCamera()
    {
    }

    [Token(Token = "0x600D022")]
    [Address(RVA = "0x9B2140", Offset = "0x9B0F40", VA = "0x109B2140")]
    private void UpdateCameraRotate()
    {
    }

    [Token(Token = "0x600D023")]
    [Address(RVA = "0x9B1FA0", Offset = "0x9B0DA0", VA = "0x109B1FA0")]
    private void UpdateCameraPosition()
    {
    }

    [Token(Token = "0x600D024")]
    [Address(RVA = "0x9B2880", Offset = "0x9B1680", VA = "0x109B2880")]
    private void UpdateGridColor()
    {
    }

    [Token(Token = "0x600D025")]
    [Address(RVA = "0x9AFD40", Offset = "0x9AEB40", VA = "0x109AFD40")]
    private List<int> CheckExistUnit(int x, int y) => (List<int>) null;

    [Token(Token = "0x600D026")]
    [Address(RVA = "0x9B3300", Offset = "0x9B2100", VA = "0x109B3300")]
    private void UpdateSelectGrid()
    {
    }

    [Token(Token = "0x600D027")]
    [Address(RVA = "0x75ABE0", Offset = "0x7599E0", VA = "0x1075ABE0")]
    private void CalcPosition(TacticsUnitController controller)
    {
    }

    [Token(Token = "0x600D028")]
    [Address(RVA = "0x9B3BC0", Offset = "0x9B29C0", VA = "0x109B3BC0")]
    private void UpdateUnitStatus(int add, bool lerp = false)
    {
    }

    [Token(Token = "0x600D029")]
    [Address(RVA = "0x9B04D0", Offset = "0x9AF2D0", VA = "0x109B04D0")]
    private int GetPlacementID(int x, int y) => new int();

    [Token(Token = "0x600D02A")]
    [Address(RVA = "0x9B1410", Offset = "0x9B0210", VA = "0x109B1410")]
    private bool IsSamePosition() => new bool();

    [Token(Token = "0x600D02B")]
    [Address(RVA = "0x9B30F0", Offset = "0x9B1EF0", VA = "0x109B30F0")]
    private void UpdateMarker(TacticsUnitController controller = null)
    {
    }

    [Token(Token = "0x600D02C")]
    [Address(RVA = "0x9B38D0", Offset = "0x9B26D0", VA = "0x109B38D0")]
    private int UpdateUnitMapPlaceIndex(
      long unit_iid,
      List<UnitMapPlacement.UnitPlaceData> unitPlaces,
      int placement_max)
    {
      return new int();
    }

    [Token(Token = "0x600D02D")]
    [Address(RVA = "0x9B0180", Offset = "0x9AEF80", VA = "0x109B0180")]
    public int GetDisplayHeight(Unit unit) => new int();

    [Token(Token = "0x600D02E")]
    [Address(RVA = "0x9B1590", Offset = "0x9B0390", VA = "0x109B1590")]
    private IEnumerator LoadSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x600D02F")]
    [Address(RVA = "0x9B1A70", Offset = "0x9B0870", VA = "0x109B1A70")]
    private void OnLoadScene(GameObject root)
    {
    }

    [Token(Token = "0x600D030")]
    [Address(RVA = "0x9AFE50", Offset = "0x9AEC50", VA = "0x109AFE50")]
    private IEnumerator ConfirmDownloadAsync(Action onDownloadPopTimeout) => (IEnumerator) null;

    [Token(Token = "0x600D031")]
    [Address(RVA = "0x9B4050", Offset = "0x9B2E50", VA = "0x109B4050")]
    public UnitMapPlacement()
    {
    }

    [Token(Token = "0x2002CC3")]
    public class UnitPlaceData
    {
      [Token(Token = "0x17001B68")]
      public UnitData unit
      {
        [Token(Token = "0x600D032"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (UnitData) null;
        }
        [Token(Token = "0x600D033"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
        {
        }
      }

      [Token(Token = "0x17001B69")]
      public int placement_idx
      {
        [Token(Token = "0x600D034"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
        [Token(Token = "0x600D035"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
        {
        }
      }

      [Token(Token = "0x600D036")]
      [Address(RVA = "0x3217D0", Offset = "0x3205D0", VA = "0x103217D0")]
      public UnitPlaceData(UnitData _unit, int _placement_idx)
      {
      }
    }
  }
}

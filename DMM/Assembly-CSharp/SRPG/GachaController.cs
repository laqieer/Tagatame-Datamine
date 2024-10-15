// Decompiled with JetBrains decompiler
// Type: SRPG.GachaController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EDD")]
  [FlowNode.Pin(250, "Setuped CardUnitAnim", FlowNode.PinTypes.Output, 250)]
  [FlowNode.Pin(202, "Next Gacha Phase", FlowNode.PinTypes.Input, 202)]
  [AddComponentMenu("Common/GachaController")]
  [FlowNode.Pin(50, "Setupd", FlowNode.PinTypes.Output, 50)]
  [FlowNode.Pin(252, "Finished CardUnitAnim", FlowNode.PinTypes.Output, 252)]
  [FlowNode.Pin(251, "Started CardUnitAnim", FlowNode.PinTypes.Output, 251)]
  [FlowNode.Pin(102, "NextBtnDisable", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "NextBtnEnable", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(200, "Setup CardUnitRarity", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(100, "InputNextBtn", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(1, "AllSkip", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(201, "Finish CardUnitAnim", FlowNode.PinTypes.Input, 201)]
  public class GachaController : MonoSingleton<GachaController>, IFlowInterface
  {
    [Token(Token = "0x4002DB9")]
    private const int PIN_OT_SETUPED = 50;
    [Token(Token = "0x4002DBA")]
    [FieldOffset(Offset = "0xC")]
    public GameObject DropStone;
    [Token(Token = "0x4002DBB")]
    [FieldOffset(Offset = "0x10")]
    public GameObject DropStone_CCard;
    [Token(Token = "0x4002DBC")]
    [FieldOffset(Offset = "0x14")]
    public GameObject DropStone_Item;
    [Token(Token = "0x4002DBD")]
    [FieldOffset(Offset = "0x18")]
    public GameObject DropStone_Artifact;
    [Token(Token = "0x4002DBE")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject DropMaterial;
    [Token(Token = "0x4002DBF")]
    [FieldOffset(Offset = "0x20")]
    public RawImage DropMaterialImage;
    [Token(Token = "0x4002DC0")]
    [FieldOffset(Offset = "0x24")]
    public RawImage DropMaterialBlurImage;
    [Token(Token = "0x4002DC1")]
    [FieldOffset(Offset = "0x28")]
    public RawImage DropMaterialIconImage;
    [Token(Token = "0x4002DC2")]
    [FieldOffset(Offset = "0x2C")]
    public Image DropMaterialIconFrameImage;
    [Token(Token = "0x4002DC3")]
    [FieldOffset(Offset = "0x30")]
    public GameObject ItemThumbnailPrefab;
    [Token(Token = "0x4002DC4")]
    [FieldOffset(Offset = "0x34")]
    public GameObject UnitThumbnailPrefab;
    [Token(Token = "0x4002DC5")]
    [FieldOffset(Offset = "0x38")]
    public GameObject ArtifactThumbnailPrefab;
    [Token(Token = "0x4002DC6")]
    [FieldOffset(Offset = "0x3C")]
    public Transform ThumbnailPool;
    [Token(Token = "0x4002DC7")]
    [FieldOffset(Offset = "0x40")]
    public GameObject StartArrowB;
    [Token(Token = "0x4002DC8")]
    [FieldOffset(Offset = "0x44")]
    public GameObject StartArrowTop;
    [Token(Token = "0x4002DC9")]
    [FieldOffset(Offset = "0x48")]
    public GameObject[] StartArrowTopMasks;
    [Token(Token = "0x4002DCA")]
    [FieldOffset(Offset = "0x4C")]
    public GameObject StartStone;
    [Token(Token = "0x4002DCB")]
    [FieldOffset(Offset = "0x50")]
    public GameObject StartStoneMask;
    [Token(Token = "0x4002DCC")]
    [FieldOffset(Offset = "0x54")]
    public GameObject StartStoneEff01;
    [Token(Token = "0x4002DCD")]
    [FieldOffset(Offset = "0x58")]
    public GameObject StartStoneEff02;
    [Token(Token = "0x4002DCE")]
    [FieldOffset(Offset = "0x5C")]
    public GameObject StartStoneEff03;
    [Token(Token = "0x4002DCF")]
    [FieldOffset(Offset = "0x60")]
    public Text MaterialName;
    [Token(Token = "0x4002DD0")]
    [FieldOffset(Offset = "0x64")]
    public Text MaterialComment;
    [Token(Token = "0x4002DD1")]
    [FieldOffset(Offset = "0x68")]
    public Text MaterialCount;
    [Token(Token = "0x4002DD2")]
    [FieldOffset(Offset = "0x6C")]
    public ImageSpriteSheet MaterialRuneType;
    [Token(Token = "0x4002DD3")]
    [FieldOffset(Offset = "0x70")]
    public GameObject[] ResetMaterials;
    [Token(Token = "0x4002DD4")]
    [FieldOffset(Offset = "0x74")]
    public Sprite[] StartArrowSprite;
    [Token(Token = "0x4002DD5")]
    [FieldOffset(Offset = "0x78")]
    public Sprite[] StartArrowTopSprite;
    [Token(Token = "0x4002DD6")]
    [FieldOffset(Offset = "0x7C")]
    public Sprite[] StartStoneSprite;
    [Token(Token = "0x4002DD7")]
    [FieldOffset(Offset = "0x80")]
    private TouchController mTouchController;
    [Token(Token = "0x4002DD8")]
    [FieldOffset(Offset = "0x84")]
    public GameObject GaugeObject;
    [Token(Token = "0x4002DD9")]
    [FieldOffset(Offset = "0x88")]
    public bool OnShardEffect;
    [Token(Token = "0x4002DDA")]
    [FieldOffset(Offset = "0x8C")]
    private StateMachine<GachaController> mState;
    [Token(Token = "0x4002DDB")]
    [FieldOffset(Offset = "0x90")]
    private bool isSkipping;
    [Token(Token = "0x4002DDC")]
    [FieldOffset(Offset = "0x94")]
    private List<GameObject> mDropStones;
    [Token(Token = "0x4002DDD")]
    [FieldOffset(Offset = "0x98")]
    private GameObject mDropMaterial;
    [Token(Token = "0x4002DDE")]
    [FieldOffset(Offset = "0x9C")]
    public GameObject OpenMaterial;
    [Token(Token = "0x4002DDF")]
    [FieldOffset(Offset = "0xA0")]
    public GameObject OpenItem;
    [Token(Token = "0x4002DE0")]
    [FieldOffset(Offset = "0xA4")]
    private bool mIgnoreDragVelocity;
    [Token(Token = "0x4002DE1")]
    [FieldOffset(Offset = "0xA5")]
    private bool mDraged;
    [Token(Token = "0x4002DE2")]
    [FieldOffset(Offset = "0xA6")]
    private bool mDraging;
    [Token(Token = "0x4002DE3")]
    [FieldOffset(Offset = "0xA7")]
    private bool mClicked;
    [Token(Token = "0x4002DE4")]
    [FieldOffset(Offset = "0xA8")]
    private float mDragY;
    [Token(Token = "0x4002DE5")]
    [FieldOffset(Offset = "0xAC")]
    private float mDragX;
    [Token(Token = "0x4002DE6")]
    [FieldOffset(Offset = "0xB0")]
    private float mDragEndX;
    [Token(Token = "0x4002DE7")]
    [FieldOffset(Offset = "0xB4")]
    private float mDragEndY;
    [Token(Token = "0x4002DE8")]
    [FieldOffset(Offset = "0xB8")]
    public float MIN_SWIPE_DIST_X;
    [Token(Token = "0x4002DE9")]
    [FieldOffset(Offset = "0xBC")]
    public float MIN_SWIPE_DIST_Y;
    [Token(Token = "0x4002DEA")]
    [FieldOffset(Offset = "0xC0")]
    public float StoneRadius;
    [Token(Token = "0x4002DEB")]
    [FieldOffset(Offset = "0xC4")]
    public float StoneAppear;
    [Token(Token = "0x4002DEC")]
    [FieldOffset(Offset = "0xC8")]
    public Texture[] StoneBases;
    [Token(Token = "0x4002DED")]
    [FieldOffset(Offset = "0xCC")]
    public Texture[] StoneHand01s;
    [Token(Token = "0x4002DEE")]
    [FieldOffset(Offset = "0xD0")]
    public Texture[] StoneHand02s;
    [Token(Token = "0x4002DEF")]
    [FieldOffset(Offset = "0xD4")]
    public Texture[] StoneEye01s;
    [Token(Token = "0x4002DF0")]
    [FieldOffset(Offset = "0xD8")]
    public Texture[] StoneEye02s;
    [Token(Token = "0x4002DF1")]
    [FieldOffset(Offset = "0xDC")]
    public Texture stoneBaseN;
    [Token(Token = "0x4002DF2")]
    [FieldOffset(Offset = "0xE0")]
    public Sprite[] LithographBases;
    [Token(Token = "0x4002DF3")]
    [FieldOffset(Offset = "0xE4")]
    public float StoneRotateTime;
    [Token(Token = "0x4002DF4")]
    [FieldOffset(Offset = "0xE8")]
    public Text ConceptCardNameText;
    [Token(Token = "0x4002DF5")]
    [FieldOffset(Offset = "0xEC")]
    public ImageArray ConceptCardFrame;
    [Token(Token = "0x4002DF6")]
    [FieldOffset(Offset = "0xF0")]
    public Texture[] ConceptCardStoneBases;
    [Token(Token = "0x4002DF7")]
    [FieldOffset(Offset = "0xF4")]
    public Texture[] ItemStoneBases;
    [Token(Token = "0x4002DF8")]
    [FieldOffset(Offset = "0xF8")]
    public Texture[] ArtifactStoneBases;
    [Token(Token = "0x4002DF9")]
    [FieldOffset(Offset = "0xFC")]
    public GameObject ConceptCardRendererPrefab;
    [Token(Token = "0x4002DFA")]
    [FieldOffset(Offset = "0x100")]
    private ConceptCardCompositeRenderer mConceptCardRenderer;
    [Token(Token = "0x4002DFB")]
    [FieldOffset(Offset = "0x104")]
    private List<GameObject> mUseThumbnailList;
    [Token(Token = "0x4002DFD")]
    private const float MinWaitBeforMoveDropStone = 2f;
    [Token(Token = "0x4002DFE")]
    [FieldOffset(Offset = "0x10C")]
    private MySound.VolumeHandle mBGMVolume;
    [Token(Token = "0x4002DFF")]
    [FieldOffset(Offset = "0x110")]
    private MySound.PlayHandle mJingleHandle;
    [Token(Token = "0x4002E00")]
    [FieldOffset(Offset = "0x114")]
    private bool AllAnimSkip;
    [Token(Token = "0x4002E01")]
    [FieldOffset(Offset = "0x115")]
    private bool mLithograph;
    [Token(Token = "0x4002E02")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int MAX_VIEW_STONE;
    [Token(Token = "0x4002E03")]
    [FieldOffset(Offset = "0x118")]
    private int mViewStoneCount;
    [Token(Token = "0x4002E04")]
    [FieldOffset(Offset = "0x11C")]
    private int mMaxPage;
    [Token(Token = "0x4002E05")]
    [FieldOffset(Offset = "0x120")]
    private int mCurrentPage;
    [Token(Token = "0x4002E06")]
    [FieldOffset(Offset = "0x124")]
    private bool IsOverMaxView;
    [Token(Token = "0x4002E07")]
    [FieldOffset(Offset = "0x125")]
    private bool IsNextDropSet;
    [Token(Token = "0x4002E08")]
    [FieldOffset(Offset = "0x126")]
    private GachaController.GachaFlowType mFlowType;
    [Token(Token = "0x4002E09")]
    [FieldOffset(Offset = "0x128")]
    private GameObject item_root;
    [Token(Token = "0x4002E0A")]
    [FieldOffset(Offset = "0x12C")]
    private int thumbnail_count;
    [Token(Token = "0x4002E0B")]
    [FieldOffset(Offset = "0x130")]
    private List<GameObject> mUnitTempList;
    [Token(Token = "0x4002E0C")]
    [FieldOffset(Offset = "0x134")]
    private List<GameObject> mItemTempList;
    [Token(Token = "0x4002E0D")]
    [FieldOffset(Offset = "0x138")]
    private List<GameObject> mArtifactTempList;
    [Token(Token = "0x4002E10")]
    [FieldOffset(Offset = "0x140")]
    public float StoneCenterHeight;
    [Token(Token = "0x4002E11")]
    [FieldOffset(Offset = "0x144")]
    private List<GameObject> m_TempList;
    [Token(Token = "0x4002E12")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    private GameObject ThumbnailTemlate;
    [Token(Token = "0x4002E13")]
    [FieldOffset(Offset = "0x14C")]
    [SerializeField]
    private Animator GetUnitAnimator;
    [Token(Token = "0x4002E14")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    private RawImage GetUnitImage;
    [Token(Token = "0x4002E15")]
    [FieldOffset(Offset = "0x154")]
    [SerializeField]
    private RawImage GetUnitBlurImage;
    [Token(Token = "0x4002E16")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    private Text GetUnitDescriptionText;
    [Token(Token = "0x4002E17")]
    [FieldOffset(Offset = "0x15C")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    [Header("演出カットprefab")]
    private string PATH_GACHA_CUT1_PREFAB;
    [Token(Token = "0x4002E18")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string PATH_GACHA_CUT2_1_PREFAB;
    [Token(Token = "0x4002E19")]
    [FieldOffset(Offset = "0x164")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string PATH_GACHA_CUT2_2_PREFAB;
    [Token(Token = "0x4002E1A")]
    [FieldOffset(Offset = "0x168")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string PATH_GACHA_CUT2_3_PREFAB;
    [Token(Token = "0x4002E1B")]
    [FieldOffset(Offset = "0x16C")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string PATH_GACHA_CUT3_PREFAB;
    [Token(Token = "0x4002E1C")]
    [FieldOffset(Offset = "0x170")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string PATH_GACHA_CUT4_1_PREFAB;
    [Token(Token = "0x4002E1D")]
    [FieldOffset(Offset = "0x174")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string PATH_GACHA_CUT4_2_PREFAB;
    [Token(Token = "0x4002E1E")]
    [FieldOffset(Offset = "0x178")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string PATH_GACHA_CUT5_1_PREFAB;
    [Token(Token = "0x4002E1F")]
    [FieldOffset(Offset = "0x17C")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string PATH_GACHA_CUT5_2_PREFAB;
    [Token(Token = "0x4002E20")]
    [FieldOffset(Offset = "0x180")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string PATH_GACHA_PICKUP_PREFAB;
    [Token(Token = "0x4002E21")]
    [FieldOffset(Offset = "0x184")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string PATH_GACHA_BACKGROUND;
    [Token(Token = "0x4002E22")]
    [FieldOffset(Offset = "0x188")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string PATH_GACHA_BACKGROUND_RESULT;
    [Token(Token = "0x4002E23")]
    [FieldOffset(Offset = "0x18C")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    [Header("排出物のモチーフ")]
    private string PATH_GACHA_DROP_UNITOBJ_PREFAB;
    [Token(Token = "0x4002E24")]
    [FieldOffset(Offset = "0x190")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string PATH_GACHA_DROP_ARTIFACTOBJ_PREFAB;
    [Token(Token = "0x4002E25")]
    [FieldOffset(Offset = "0x194")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string PATH_GACHA_DROP_CCARDOBJ_PREFAB;
    [Token(Token = "0x4002E26")]
    [FieldOffset(Offset = "0x198")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string PATH_GACHA_DROP_ITEMOBJ_PREFAB;
    [Token(Token = "0x4002E27")]
    [FieldOffset(Offset = "0x19C")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string PATH_GACHA_DROP_CRYSTALOBJ_PREFAB;
    [Token(Token = "0x4002E28")]
    [FieldOffset(Offset = "0x1A0")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string PATH_GACHA_DROP_NORMALOBJ_PREFAB;
    [Token(Token = "0x4002E29")]
    [FieldOffset(Offset = "0x1A4")]
    [Header("最終カットを表示するカメラ")]
    [SerializeField]
    private UnityEngine.Camera m_CharaCamera;
    [Token(Token = "0x4002E2A")]
    [FieldOffset(Offset = "0x1A8")]
    [SerializeField]
    private UnityEngine.Camera m_BackCamera;
    [Token(Token = "0x4002E2B")]
    [FieldOffset(Offset = "0x1AC")]
    [SerializeField]
    [Header("星5ピックアップ時にリル＝ウロボロスが出現する確率 100分率")]
    private int m_OuroborosRate;
    [Token(Token = "0x4002E2C")]
    [FieldOffset(Offset = "0x1B0")]
    [SerializeField]
    [Header("ユニット排出時のボイス")]
    private string UNIT_GET_VOICE;
    [Token(Token = "0x4002E2D")]
    [FieldOffset(Offset = "0x1B4")]
    [Header("ユニット排出時のボイス再生タイミング")]
    [SerializeField]
    private float UNIT_GET_VOICE_DELAY;
    [Token(Token = "0x4002E2E")]
    [FieldOffset(Offset = "0x1B8")]
    private GameObject m_Cut1;
    [Token(Token = "0x4002E2F")]
    [FieldOffset(Offset = "0x1BC")]
    private GameObject m_Cut2;
    [Token(Token = "0x4002E30")]
    [FieldOffset(Offset = "0x1C0")]
    private GameObject m_Cut3;
    [Token(Token = "0x4002E31")]
    [FieldOffset(Offset = "0x1C4")]
    private GameObject m_Cut4;
    [Token(Token = "0x4002E32")]
    [FieldOffset(Offset = "0x1C8")]
    private GameObject m_Cut5;
    [Token(Token = "0x4002E33")]
    [FieldOffset(Offset = "0x1CC")]
    private GameObject m_Cut5_pu;
    [Token(Token = "0x4002E34")]
    [FieldOffset(Offset = "0x1D0")]
    private GameObject m_Pickup;
    [Token(Token = "0x4002E35")]
    [FieldOffset(Offset = "0x1D4")]
    private GameObject m_BackGround;
    [Token(Token = "0x4002E36")]
    [FieldOffset(Offset = "0x1D8")]
    private GameObject m_BackGround_Result;
    [Token(Token = "0x4002E37")]
    [FieldOffset(Offset = "0x1DC")]
    private Animation m_Cut1_Anim;
    [Token(Token = "0x4002E38")]
    [FieldOffset(Offset = "0x1E0")]
    private Animation m_Cut2_Anim;
    [Token(Token = "0x4002E39")]
    [FieldOffset(Offset = "0x1E4")]
    private Animation m_Cut3_Anim;
    [Token(Token = "0x4002E3A")]
    [FieldOffset(Offset = "0x1E8")]
    private Animation m_Cut4_Anim;
    [Token(Token = "0x4002E3B")]
    [FieldOffset(Offset = "0x1EC")]
    private Animation m_Cut5_Anim;
    [Token(Token = "0x4002E3C")]
    [FieldOffset(Offset = "0x1F0")]
    private Animation m_Cut5_pu_Anim;
    [Token(Token = "0x4002E3D")]
    [FieldOffset(Offset = "0x1F4")]
    private Animator m_Pickup_Animator;
    [Token(Token = "0x4002E3E")]
    [FieldOffset(Offset = "0x1F8")]
    private Animation m_CurrentAnim;
    [Token(Token = "0x4002E3F")]
    [FieldOffset(Offset = "0x1FC")]
    private GameObject[] m_DropObjects;
    [Token(Token = "0x4002E40")]
    [FieldOffset(Offset = "0x200")]
    private GameObject m_PrevDropObject;
    [Token(Token = "0x4002E41")]
    [FieldOffset(Offset = "0x204")]
    private GachaPickupParts m_PickupParts;
    [Token(Token = "0x4002E42")]
    [FieldOffset(Offset = "0x208")]
    private bool m_pickup_flag;
    [Token(Token = "0x4002E43")]
    [FieldOffset(Offset = "0x209")]
    private bool m_pickup_anim_use_flag;
    [Token(Token = "0x4002E44")]
    [FieldOffset(Offset = "0x20C")]
    private List<GachaController.PickupAnimType> m_pickup_anim_type_list;
    [Token(Token = "0x4002E45")]
    [FieldOffset(Offset = "0x210")]
    private MySound.Voice m_UnitVoice;

    [Token(Token = "0x170004F1")]
    public int GachaSequence
    {
      [Token(Token = "0x6003DBE"), Address(RVA = "0x11043A0", Offset = "0x11031A0", VA = "0x111043A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170004F2")]
    private Canvas OverlayCanvas
    {
      [Token(Token = "0x6003DBF"), Address(RVA = "0x1104C90", Offset = "0x1103A90", VA = "0x11104C90")] get
      {
        return (Canvas) null;
      }
    }

    [Token(Token = "0x6003DC0")]
    [Address(RVA = "0x1100840", Offset = "0x10FF640", VA = "0x11100840")]
    public bool IsAssetDownloadDone() => new bool();

    [Token(Token = "0x170004F3")]
    private GachaController.DropInfo DropCurrent
    {
      [Token(Token = "0x6003DC1"), Address(RVA = "0x6718E0", Offset = "0x6706E0", VA = "0x106718E0")] get
      {
        return (GachaController.DropInfo) null;
      }
      [Token(Token = "0x6003DC2"), Address(RVA = "0x6857F0", Offset = "0x6845F0", VA = "0x106857F0")] set
      {
      }
    }

    [Token(Token = "0x170004F4")]
    public GachaDropData CurrentDropData
    {
      [Token(Token = "0x6003DC3"), Address(RVA = "0x11042C0", Offset = "0x11030C0", VA = "0x111042C0")] get
      {
        return (GachaDropData) null;
      }
    }

    [Token(Token = "0x170004F5")]
    public int Rarity
    {
      [Token(Token = "0x6003DC4"), Address(RVA = "0x1104D40", Offset = "0x1103B40", VA = "0x11104D40")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170004F6")]
    public bool Shard
    {
      [Token(Token = "0x6003DC5"), Address(RVA = "0x1104D60", Offset = "0x1103B60", VA = "0x11104D60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004F7")]
    public bool Item
    {
      [Token(Token = "0x6003DC6"), Address(RVA = "0x1104C60", Offset = "0x1103A60", VA = "0x11104C60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004F8")]
    public bool IsConceptCard
    {
      [Token(Token = "0x6003DC7"), Address(RVA = "0x11043F0", Offset = "0x11031F0", VA = "0x111043F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004F9")]
    public bool Pickup
    {
      [Token(Token = "0x6003DC8"), Address(RVA = "0x1104D20", Offset = "0x1103B20", VA = "0x11104D20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004FA")]
    private int mFirstSeq
    {
      [Token(Token = "0x6003DC9"), Address(RVA = "0x1104E10", Offset = "0x1103C10", VA = "0x11104E10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170004FB")]
    private int mSecondSeq
    {
      [Token(Token = "0x6003DCA"), Address(RVA = "0x1104F30", Offset = "0x1103D30", VA = "0x11104F30")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170004FC")]
    private int mThirdSeq
    {
      [Token(Token = "0x6003DCB"), Address(RVA = "0x1104FC0", Offset = "0x1103DC0", VA = "0x11104FC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170004FD")]
    private int mFourthSeq
    {
      [Token(Token = "0x6003DCC"), Address(RVA = "0x1104EA0", Offset = "0x1103CA0", VA = "0x11104EA0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170004FE")]
    private int mFifthSeq
    {
      [Token(Token = "0x6003DCD"), Address(RVA = "0x1104D80", Offset = "0x1103B80", VA = "0x11104D80")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6003DCE")]
    [Address(RVA = "0x10FF6D0", Offset = "0x10FE4D0", VA = "0x110FF6D0")]
    private IEnumerator CreateDropInfo() => (IEnumerator) null;

    [Token(Token = "0x6003DCF")]
    [Address(RVA = "0x1101470", Offset = "0x1100270", VA = "0x11101470")]
    public void PlayJINGLE0010()
    {
    }

    [Token(Token = "0x170004FF")]
    public bool IsLithograph
    {
      [Token(Token = "0x6003DD0"), Address(RVA = "0x1104410", Offset = "0x1103210", VA = "0x11104410")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003DD1"), Address(RVA = "0x1105070", Offset = "0x1103E70", VA = "0x11105070")] set
      {
      }
    }

    [Token(Token = "0x17000500")]
    public int DropIndex
    {
      [Token(Token = "0x6003DD2"), Address(RVA = "0x1104370", Offset = "0x1103170", VA = "0x11104370")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000501")]
    public bool FinishedCardUnitAnimation
    {
      [Token(Token = "0x6003DD3"), Address(RVA = "0x1104390", Offset = "0x1103190", VA = "0x11104390")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003DD4"), Address(RVA = "0x1105050", Offset = "0x1103E50", VA = "0x11105050")] set
      {
      }
    }

    [Token(Token = "0x17000502")]
    public bool NextGachaPhase
    {
      [Token(Token = "0x6003DD5"), Address(RVA = "0x1104C80", Offset = "0x1103A80", VA = "0x11104C80")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003DD6"), Address(RVA = "0x1105090", Offset = "0x1103E90", VA = "0x11105090")] set
      {
      }
    }

    [Token(Token = "0x6003DD7")]
    [Address(RVA = "0x10FF540", Offset = "0x10FE340", VA = "0x110FF540", Slot = "6")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6003DD8")]
    [Address(RVA = "0x1103840", Offset = "0x1102640", VA = "0x11103840")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x6003DD9")]
    [Address(RVA = "0x10FF690", Offset = "0x10FE490", VA = "0x110FF690")]
    private Color ConvertColor(Color color) => new Color();

    [Token(Token = "0x6003DDA")]
    [Address(RVA = "0x1103D00", Offset = "0x1102B00", VA = "0x11103D00")]
    private void Update()
    {
    }

    [Token(Token = "0x6003DDB")]
    [Address(RVA = "0x1100630", Offset = "0x10FF430", VA = "0x11100630")]
    private IEnumerator InitTempList() => (IEnumerator) null;

    [Token(Token = "0x6003DDC")]
    [Address(RVA = "0x10FF7F0", Offset = "0x10FE5F0", VA = "0x110FF7F0")]
    private IEnumerator CreateThumbnailObject(GachaDropData.Type type) => (IEnumerator) null;

    [Token(Token = "0x6003DDD")]
    [Address(RVA = "0x1101770", Offset = "0x1100570", VA = "0x11101770")]
    public void RefreshThumbnailList()
    {
    }

    [Token(Token = "0x6003DDE")]
    [Address(RVA = "0x10FFD90", Offset = "0x10FEB90", VA = "0x110FFD90")]
    private UnitData CreateUnitData(UnitParam uparam) => (UnitData) null;

    [Token(Token = "0x6003DDF")]
    [Address(RVA = "0x10FF730", Offset = "0x10FE530", VA = "0x110FF730")]
    public static ArtifactData CreateTempArtifactData(ArtifactParam param, int rarity)
    {
      return (ArtifactData) null;
    }

    [Token(Token = "0x6003DE0")]
    [Address(RVA = "0x1100E50", Offset = "0x10FFC50", VA = "0x11100E50")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6003DE1")]
    [Address(RVA = "0x10FF860", Offset = "0x10FE660", VA = "0x110FF860")]
    private void CreateTouchArea()
    {
    }

    [Token(Token = "0x6003DE2")]
    [Address(RVA = "0x11000B0", Offset = "0x10FEEB0", VA = "0x111000B0")]
    private void DestroyTouchArea()
    {
    }

    [Token(Token = "0x6003DE3")]
    [Address(RVA = "0x1100C90", Offset = "0x10FFA90", VA = "0x11100C90")]
    private void OnClick(Vector2 screenPosition)
    {
    }

    [Token(Token = "0x6003DE4")]
    [Address(RVA = "0x1101090", Offset = "0x10FFE90", VA = "0x11101090")]
    private void OnDrag()
    {
    }

    [Token(Token = "0x6003DE5")]
    [Address(RVA = "0x1101030", Offset = "0x10FFE30", VA = "0x11101030")]
    private void OnDragEnd()
    {
    }

    [Token(Token = "0x6003DE6")]
    [Address(RVA = "0x10FF660", Offset = "0x10FE460", VA = "0x110FF660")]
    private bool CheckSkip() => new bool();

    [Token(Token = "0x6003DE7")]
    [Address(RVA = "0x1100400", Offset = "0x10FF200", VA = "0x11100400")]
    private int GetRarityTextureIndex(int rarity) => new int();

    [Token(Token = "0x6003DE8")]
    [Address(RVA = "0x1101590", Offset = "0x1100390", VA = "0x11101590")]
    public void RefreshGachaImageSize(RectTransform _rect_tf, GachaDropData.Type _type)
    {
    }

    [Token(Token = "0x6003DE9")]
    [Address(RVA = "0x11003A0", Offset = "0x10FF1A0", VA = "0x111003A0")]
    public GameObject GetDropStone(GachaDropData _drop) => (GameObject) null;

    [Token(Token = "0x6003DEA")]
    [Address(RVA = "0x1100690", Offset = "0x10FF490", VA = "0x11100690")]
    private bool InitThumbnailTemplateList() => new bool();

    [Token(Token = "0x6003DEB")]
    [Address(RVA = "0x1101E00", Offset = "0x1100C00", VA = "0x11101E00")]
    private bool ResetThumbnailList() => new bool();

    [Token(Token = "0x6003DEC")]
    [Address(RVA = "0x1101BD0", Offset = "0x11009D0", VA = "0x11101BD0")]
    private void ResetThumbnailIcon(SerializeValueBehaviour svb, string name)
    {
    }

    [Token(Token = "0x6003DED")]
    [Address(RVA = "0x1102540", Offset = "0x1101340", VA = "0x11102540")]
    private GameObject SetThumbnailValid(
      SerializeValueBehaviour _valuelist,
      string _name,
      bool _active)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6003DEE")]
    [Address(RVA = "0x1102A50", Offset = "0x1101850", VA = "0x11102A50")]
    private bool SetupThumbnail(GameObject _thumbnail, GachaDropData _data) => new bool();

    [Token(Token = "0x6003DEF")]
    [Address(RVA = "0x1100420", Offset = "0x10FF220", VA = "0x11100420")]
    private GameObject GetThumbnailObject(int _index) => (GameObject) null;

    [Token(Token = "0x6003DF0")]
    [Address(RVA = "0x1100480", Offset = "0x10FF280", VA = "0x11100480")]
    private GameObject GetThumbnailTypeObject(GameObject _thumbnail, GachaDropData.Type _type)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6003DF1")]
    [Address(RVA = "0x1102120", Offset = "0x1100F20", VA = "0x11102120")]
    private void SetGetUnitParameter(UnitParam _unit_param, string _ccard_name)
    {
    }

    [Token(Token = "0x6003DF2")]
    [Address(RVA = "0x1101A90", Offset = "0x1100890", VA = "0x11101A90")]
    private void ResetGetUnitAnim()
    {
    }

    [Token(Token = "0x6003DF3")]
    [Address(RVA = "0x11028F0", Offset = "0x11016F0", VA = "0x111028F0")]
    private void SetupGetCardUnitAnim()
    {
    }

    [Token(Token = "0x6003DF4")]
    [Address(RVA = "0x1103780", Offset = "0x1102580", VA = "0x11103780")]
    private void StartGetCardUnitAnim()
    {
    }

    [Token(Token = "0x6003DF5")]
    [Address(RVA = "0x1101A00", Offset = "0x1100800", VA = "0x11101A00")]
    private void ResetGetCardUnitAnim()
    {
    }

    [Token(Token = "0x6003DF6")]
    [Address(RVA = "0x1100920", Offset = "0x10FF720", VA = "0x11100920")]
    private bool IsNormalGacha() => new bool();

    [Token(Token = "0x6003DF7")]
    [Address(RVA = "0x11009A0", Offset = "0x10FF7A0", VA = "0x111009A0")]
    private bool IsSingleGacha() => new bool();

    [Token(Token = "0x6003DF8")]
    [Address(RVA = "0x1100940", Offset = "0x10FF740", VA = "0x11100940")]
    private bool IsSingleAnimation() => new bool();

    [Token(Token = "0x17000503")]
    public bool IsSetupedCut1
    {
      [Token(Token = "0x6003DF9"), Address(RVA = "0x11044A0", Offset = "0x11032A0", VA = "0x111044A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000504")]
    public bool IsSetupedCut2
    {
      [Token(Token = "0x6003DFA"), Address(RVA = "0x1104520", Offset = "0x1103320", VA = "0x11104520")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000505")]
    public bool IsSetupedCut3
    {
      [Token(Token = "0x6003DFB"), Address(RVA = "0x11045A0", Offset = "0x11033A0", VA = "0x111045A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000506")]
    public bool IsSetupedCut4
    {
      [Token(Token = "0x6003DFC"), Address(RVA = "0x1104620", Offset = "0x1103420", VA = "0x11104620")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000507")]
    public bool IsSetupedCut5
    {
      [Token(Token = "0x6003DFD"), Address(RVA = "0x11046A0", Offset = "0x11034A0", VA = "0x111046A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000508")]
    public bool IsSetupedPickup
    {
      [Token(Token = "0x6003DFE"), Address(RVA = "0x1104BA0", Offset = "0x11039A0", VA = "0x11104BA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000509")]
    public bool IsSetupedBG
    {
      [Token(Token = "0x6003DFF"), Address(RVA = "0x1104420", Offset = "0x1103220", VA = "0x11104420")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700050A")]
    public bool IsSetupedCut
    {
      [Token(Token = "0x6003E00"), Address(RVA = "0x1104790", Offset = "0x1103590", VA = "0x11104790")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003E01")]
    [Address(RVA = "0x1100B90", Offset = "0x10FF990", VA = "0x11100B90")]
    public bool IsUseLastPickupAnim() => new bool();

    [Token(Token = "0x6003E02")]
    [Address(RVA = "0x1100C30", Offset = "0x10FFA30", VA = "0x11100C30")]
    private IEnumerator LoadAnimationMaterial() => (IEnumerator) null;

    [Token(Token = "0x6003E03")]
    [Address(RVA = "0x11025F0", Offset = "0x11013F0", VA = "0x111025F0")]
    private void SetupAnimationParts()
    {
    }

    [Token(Token = "0x6003E04")]
    [Address(RVA = "0x1102910", Offset = "0x1101710", VA = "0x11102910")]
    private void SetupLastCutAnimationParts(GameObject cut_obj)
    {
    }

    [Token(Token = "0x6003E05")]
    [Address(RVA = "0x11014F0", Offset = "0x11002F0", VA = "0x111014F0")]
    private void PlayStartupAnimation()
    {
    }

    [Token(Token = "0x6003E06")]
    [Address(RVA = "0x11038A0", Offset = "0x11026A0", VA = "0x111038A0")]
    private void UpdateAnimationState()
    {
    }

    [Token(Token = "0x6003E07")]
    [Address(RVA = "0x1103350", Offset = "0x1102150", VA = "0x11103350")]
    private void SkipAnimationState()
    {
    }

    [Token(Token = "0x6003E08")]
    [Address(RVA = "0x11023C0", Offset = "0x11011C0", VA = "0x111023C0")]
    private void SetNextDropAnimation(bool is_pu)
    {
    }

    [Token(Token = "0x6003E09")]
    [Address(RVA = "0x11009F0", Offset = "0x10FF7F0", VA = "0x111009F0")]
    private bool IsStartupAnimationEnd(bool is_pu) => new bool();

    [Token(Token = "0x6003E0A")]
    [Address(RVA = "0x1100150", Offset = "0x10FEF50", VA = "0x11100150")]
    private void EndStartupAnimation()
    {
    }

    [Token(Token = "0x6003E0B")]
    [Address(RVA = "0x11008B0", Offset = "0x10FF6B0", VA = "0x111008B0")]
    private bool IsDropEnd() => new bool();

    [Token(Token = "0x6003E0C")]
    [Address(RVA = "0x11010F0", Offset = "0x10FFEF0", VA = "0x111010F0")]
    private void PlayAnimCut5()
    {
    }

    [Token(Token = "0x6003E0D")]
    [Address(RVA = "0x1101640", Offset = "0x1100440", VA = "0x11101640")]
    private void RefreshPickupParts()
    {
    }

    [Token(Token = "0x6003E0E")]
    [Address(RVA = "0x11020D0", Offset = "0x1100ED0", VA = "0x111020D0")]
    private void ResetUnitVoice()
    {
    }

    [Token(Token = "0x6003E0F")]
    [Address(RVA = "0x11031B0", Offset = "0x1101FB0", VA = "0x111031B0")]
    private void SetupUnitVoice()
    {
    }

    [Token(Token = "0x6003E10")]
    [Address(RVA = "0x1101550", Offset = "0x1100350", VA = "0x11101550")]
    private void PlayUnitVoice()
    {
    }

    [Token(Token = "0x6003E11")]
    [Address(RVA = "0x1103E30", Offset = "0x1102C30", VA = "0x11103E30")]
    public GachaController()
    {
    }

    [Token(Token = "0x6003E12")]
    [Address(RVA = "0x1103DF0", Offset = "0x1102BF0", VA = "0x11103DF0")]
    static GachaController()
    {
    }

    [Token(Token = "0x2000EDE")]
    private class DropInfo
    {
      [Token(Token = "0x1700050B")]
      public int Index
      {
        [Token(Token = "0x6003E13"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
        [Token(Token = "0x6003E14"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
        {
        }
      }

      [Token(Token = "0x1700050C")]
      public string Name
      {
        [Token(Token = "0x6003E15"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6003E16"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
        {
        }
      }

      [Token(Token = "0x1700050D")]
      public int Rarity
      {
        [Token(Token = "0x6003E17"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return new int();
        }
        [Token(Token = "0x6003E18"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
        {
        }
      }

      [Token(Token = "0x1700050E")]
      public bool IsShard
      {
        [Token(Token = "0x6003E19"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
        {
          return new bool();
        }
        [Token(Token = "0x6003E1A"), Address(RVA = "0x357B00", Offset = "0x356900", VA = "0x10357B00")] private set
        {
        }
      }

      [Token(Token = "0x1700050F")]
      public bool IsItem
      {
        [Token(Token = "0x6003E1B"), Address(RVA = "0x39C2B0", Offset = "0x39B0B0", VA = "0x1039C2B0")] get
        {
          return new bool();
        }
        [Token(Token = "0x6003E1C"), Address(RVA = "0x7B1CA0", Offset = "0x7B0AA0", VA = "0x107B1CA0")] private set
        {
        }
      }

      [Token(Token = "0x17000510")]
      public string OName
      {
        [Token(Token = "0x6003E1D"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6003E1E"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
        {
        }
      }

      [Token(Token = "0x17000511")]
      public int Num
      {
        [Token(Token = "0x6003E1F"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return new int();
        }
        [Token(Token = "0x6003E20"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] private set
        {
        }
      }

      [Token(Token = "0x17000512")]
      public int[] Excites
      {
        [Token(Token = "0x6003E21"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
        {
          return (int[]) null;
        }
        [Token(Token = "0x6003E22"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
        {
        }
      }

      [Token(Token = "0x17000513")]
      public bool IsConceptCard
      {
        [Token(Token = "0x6003E23"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
        {
          return new bool();
        }
        [Token(Token = "0x6003E24"), Address(RVA = "0x2A5AD0", Offset = "0x2A48D0", VA = "0x102A5AD0")] private set
        {
        }
      }

      [Token(Token = "0x17000514")]
      public bool IsCardUnit
      {
        [Token(Token = "0x6003E25"), Address(RVA = "0x628F10", Offset = "0x627D10", VA = "0x10628F10")] get
        {
          return new bool();
        }
        [Token(Token = "0x6003E26"), Address(RVA = "0x6E63C0", Offset = "0x6E51C0", VA = "0x106E63C0")] private set
        {
        }
      }

      [Token(Token = "0x17000515")]
      public int CardUnitRarity
      {
        [Token(Token = "0x6003E27"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
        {
          return new int();
        }
        [Token(Token = "0x6003E28"), Address(RVA = "0x36F650", Offset = "0x36E450", VA = "0x1036F650")] private set
        {
        }
      }

      [Token(Token = "0x17000516")]
      public bool IsPickup
      {
        [Token(Token = "0x6003E29"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
        {
          return new bool();
        }
        [Token(Token = "0x6003E2A"), Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", VA = "0x104A9DB0")] private set
        {
        }
      }

      [Token(Token = "0x6003E2B")]
      [Address(RVA = "0x10F5700", Offset = "0x10F4500", VA = "0x110F5700")]
      public static GachaController.DropInfo Create(GachaController self)
      {
        return (GachaController.DropInfo) null;
      }

      [Token(Token = "0x6003E2C")]
      [Address(RVA = "0x10F5980", Offset = "0x10F4780", VA = "0x110F5980")]
      public void Reflesh(GachaController self, int index = 0)
      {
      }

      [Token(Token = "0x6003E2D")]
      [Address(RVA = "0x10F6BE0", Offset = "0x10F59E0", VA = "0x110F6BE0")]
      private void SetUnit(GachaController self, GachaDropData drop)
      {
      }

      [Token(Token = "0x6003E2E")]
      [Address(RVA = "0x10F6720", Offset = "0x10F5520", VA = "0x110F6720")]
      private void SetItem(GachaController self, GachaDropData drop, int index)
      {
      }

      [Token(Token = "0x6003E2F")]
      [Address(RVA = "0x10F5760", Offset = "0x10F4560", VA = "0x110F5760")]
      private void InitalizeUnitShardGauge(
        GachaController self,
        UnitParam unitParam,
        int drop_num,
        int index)
      {
      }

      [Token(Token = "0x6003E30")]
      [Address(RVA = "0x10F5E00", Offset = "0x10F4C00", VA = "0x110F5E00")]
      private void SetArtifact(GachaController self, GachaDropData drop)
      {
      }

      [Token(Token = "0x6003E31")]
      [Address(RVA = "0x10F6110", Offset = "0x10F4F10", VA = "0x110F6110")]
      private void SetConceptCard(GachaController self, GachaDropData drop)
      {
      }

      [Token(Token = "0x6003E32")]
      [Address(RVA = "0x10F6540", Offset = "0x10F5340", VA = "0x110F6540")]
      private void SetCrystal(GachaController self, GachaDropData drop)
      {
      }

      [Token(Token = "0x6003E33")]
      [Address(RVA = "0x10F5940", Offset = "0x10F4740", VA = "0x110F5940")]
      public void Next(GachaController self)
      {
      }

      [Token(Token = "0x6003E34")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public DropInfo()
      {
      }
    }

    [Token(Token = "0x2000EDF")]
    private enum GachaFlowType : byte
    {
      [Token(Token = "0x4002E53")] Rare,
      [Token(Token = "0x4002E54")] Normal,
      [Token(Token = "0x4002E55")] Special,
    }

    [Token(Token = "0x2000EE0")]
    private class State_InitDropThumbnail : State<GachaController>
    {
      [Token(Token = "0x6003E35")]
      [Address(RVA = "0x11842C0", Offset = "0x11830C0", VA = "0x111842C0", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E36")]
      [Address(RVA = "0x1184670", Offset = "0x1183470", VA = "0x11184670")]
      public State_InitDropThumbnail()
      {
      }
    }

    [Token(Token = "0x2000EE1")]
    private class State_OpenDropThumbnail : State<GachaController>
    {
      [Token(Token = "0x6003E37")]
      [Address(RVA = "0x1185EB0", Offset = "0x1184CB0", VA = "0x11185EB0", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E38")]
      [Address(RVA = "0x1186060", Offset = "0x1184E60", VA = "0x11186060")]
      public State_OpenDropThumbnail()
      {
      }
    }

    [Token(Token = "0x2000EE2")]
    private class State_WaitThumbnailAnimation : State<GachaController>
    {
      [Token(Token = "0x4002E56")]
      [FieldOffset(Offset = "0xC")]
      private bool isSetup;
      [Token(Token = "0x4002E57")]
      [FieldOffset(Offset = "0x10")]
      private Animation anim;

      [Token(Token = "0x6003E39")]
      [Address(RVA = "0x11887F0", Offset = "0x11875F0", VA = "0x111887F0", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E3A")]
      [Address(RVA = "0x1188B30", Offset = "0x1187930", VA = "0x11188B30", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003E3B")]
      [Address(RVA = "0x1188BD0", Offset = "0x11879D0", VA = "0x11188BD0")]
      public State_WaitThumbnailAnimation()
      {
      }
    }

    [Token(Token = "0x2000EE3")]
    private class State_OpenDropMaterialT : State<GachaController>
    {
      [Token(Token = "0x6003E3C")]
      [Address(RVA = "0x1185190", Offset = "0x1183F90", VA = "0x11185190", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E3D")]
      [Address(RVA = "0x11853F0", Offset = "0x11841F0", VA = "0x111853F0")]
      public State_OpenDropMaterialT()
      {
      }
    }

    [Token(Token = "0x2000EE4")]
    private class State_WaitDropmaterialT : State<GachaController>
    {
      [Token(Token = "0x6003E3E")]
      [Address(RVA = "0x1187C10", Offset = "0x1186A10", VA = "0x11187C10", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E3F")]
      [Address(RVA = "0x1187C30", Offset = "0x1186A30", VA = "0x11187C30", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003E40")]
      [Address(RVA = "0x1187CD0", Offset = "0x1186AD0", VA = "0x11187CD0")]
      public State_WaitDropmaterialT()
      {
      }
    }

    [Token(Token = "0x2000EE5")]
    private class State_DisableDropMaterialT : State<GachaController>
    {
      [Token(Token = "0x6003E41")]
      [Address(RVA = "0x1183930", Offset = "0x1182730", VA = "0x11183930", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E42")]
      [Address(RVA = "0x1183B10", Offset = "0x1182910", VA = "0x11183B10")]
      public State_DisableDropMaterialT()
      {
      }
    }

    [Token(Token = "0x2000EE6")]
    private class State_CheckThumbnail : State<GachaController>
    {
      [Token(Token = "0x6003E43")]
      [Address(RVA = "0x11831F0", Offset = "0x1181FF0", VA = "0x111831F0", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E44")]
      [Address(RVA = "0x11833F0", Offset = "0x11821F0", VA = "0x111833F0")]
      public State_CheckThumbnail()
      {
      }
    }

    [Token(Token = "0x2000EE7")]
    private class State_CheckNextDropSet : State<GachaController>
    {
      [Token(Token = "0x6003E45")]
      [Address(RVA = "0x1183120", Offset = "0x1181F20", VA = "0x11183120", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E46")]
      [Address(RVA = "0x11831B0", Offset = "0x1181FB0", VA = "0x111831B0")]
      public State_CheckNextDropSet()
      {
      }
    }

    [Token(Token = "0x2000EE8")]
    private class State_WaitForInput_NextDropSet : State<GachaController>
    {
      [Token(Token = "0x6003E47")]
      [Address(RVA = "0x9DED10", Offset = "0x9DDB10", VA = "0x109DED10", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E48")]
      [Address(RVA = "0x1187DB0", Offset = "0x1186BB0", VA = "0x11187DB0", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003E49")]
      [Address(RVA = "0x1187E10", Offset = "0x1186C10", VA = "0x11187E10")]
      public State_WaitForInput_NextDropSet()
      {
      }
    }

    [Token(Token = "0x2000EE9")]
    private class State_InitNextDropSet : State<GachaController>
    {
      [Token(Token = "0x6003E4A")]
      [Address(RVA = "0x11846B0", Offset = "0x11834B0", VA = "0x111846B0", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E4B")]
      [Address(RVA = "0x1184720", Offset = "0x1183520", VA = "0x11184720")]
      public State_InitNextDropSet()
      {
      }
    }

    [Token(Token = "0x2000EEA")]
    private class State_OpenDropMaterialShard : State<GachaController>
    {
      [Token(Token = "0x6003E4C")]
      [Address(RVA = "0x1184F00", Offset = "0x1183D00", VA = "0x11184F00", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E4D")]
      [Address(RVA = "0x1185150", Offset = "0x1183F50", VA = "0x11185150")]
      public State_OpenDropMaterialShard()
      {
      }
    }

    [Token(Token = "0x2000EEB")]
    private class State_WaitDropmaterialShard : State<GachaController>
    {
      [Token(Token = "0x6003E4E")]
      [Address(RVA = "0x1187B30", Offset = "0x1186930", VA = "0x11187B30", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003E4F")]
      [Address(RVA = "0x1187BD0", Offset = "0x11869D0", VA = "0x11187BD0")]
      public State_WaitDropmaterialShard()
      {
      }
    }

    [Token(Token = "0x2000EEC")]
    private class State_SettingDisableDropMaterialShard : State<GachaController>
    {
      [Token(Token = "0x6003E50")]
      [Address(RVA = "0x1186160", Offset = "0x1184F60", VA = "0x11186160", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E51")]
      [Address(RVA = "0x11862E0", Offset = "0x11850E0", VA = "0x111862E0")]
      public State_SettingDisableDropMaterialShard()
      {
      }
    }

    [Token(Token = "0x2000EED")]
    private class State_DisableDropMaterialShard : State<GachaController>
    {
      [Token(Token = "0x6003E52")]
      [Address(RVA = "0x1183720", Offset = "0x1182520", VA = "0x11183720", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E53")]
      [Address(RVA = "0x11838F0", Offset = "0x11826F0", VA = "0x111838F0")]
      public State_DisableDropMaterialShard()
      {
      }
    }

    [Token(Token = "0x2000EEE")]
    private class State_Init : State<GachaController>
    {
      [Token(Token = "0x6003E54")]
      [Address(RVA = "0x1184760", Offset = "0x1183560", VA = "0x11184760", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E55")]
      [Address(RVA = "0x11847B0", Offset = "0x11835B0", VA = "0x111847B0")]
      public State_Init()
      {
      }
    }

    [Token(Token = "0x2000EEF")]
    private class State_WaitStartupAnimation : State<GachaController>
    {
      [Token(Token = "0x6003E56")]
      [Address(RVA = "0x11886D0", Offset = "0x11874D0", VA = "0x111886D0", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E57")]
      [Address(RVA = "0x1188700", Offset = "0x1187500", VA = "0x11188700", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003E58")]
      [Address(RVA = "0x11887B0", Offset = "0x11875B0", VA = "0x111887B0")]
      public State_WaitStartupAnimation()
      {
      }
    }

    [Token(Token = "0x2000EF0")]
    private class State_WaitInputFlick : State<GachaController>
    {
      [Token(Token = "0x4002E58")]
      [FieldOffset(Offset = "0xC")]
      private bool mSuccessDistX;
      [Token(Token = "0x4002E59")]
      [FieldOffset(Offset = "0xD")]
      private bool mSuccessDistY;
      [Token(Token = "0x4002E5A")]
      [FieldOffset(Offset = "0x10")]
      private Animator atr;

      [Token(Token = "0x6003E59")]
      [Address(RVA = "0x1188320", Offset = "0x1187120", VA = "0x11188320", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E5A")]
      [Address(RVA = "0x1188380", Offset = "0x1187180", VA = "0x11188380", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003E5B")]
      [Address(RVA = "0x1188690", Offset = "0x1187490", VA = "0x11188690")]
      public State_WaitInputFlick()
      {
      }
    }

    [Token(Token = "0x2000EF1")]
    private class State_WaitBeforeSummons : State<GachaController>
    {
      [Token(Token = "0x6003E5C")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E5D")]
      [Address(RVA = "0x11873B0", Offset = "0x11861B0", VA = "0x111873B0", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003E5E")]
      [Address(RVA = "0x1187660", Offset = "0x1186460", VA = "0x11187660")]
      public State_WaitBeforeSummons()
      {
      }
    }

    [Token(Token = "0x2000EF2")]
    private class State_SettingDropStoneSkip : State<GachaController>
    {
      [Token(Token = "0x6003E5F")]
      [Address(RVA = "0x1186530", Offset = "0x1185330", VA = "0x11186530", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E60")]
      [Address(RVA = "0x1186580", Offset = "0x1185380", VA = "0x11186580")]
      public State_SettingDropStoneSkip()
      {
      }
    }

    [Token(Token = "0x2000EF3")]
    private class State_SettingDropStone : State<GachaController>
    {
      [Token(Token = "0x4002E5B")]
      [FieldOffset(Offset = "0xC")]
      private float mRadius;
      [Token(Token = "0x4002E5C")]
      [FieldOffset(Offset = "0x10")]
      private float mAppear;

      [Token(Token = "0x6003E61")]
      [Address(RVA = "0x11865C0", Offset = "0x11853C0", VA = "0x111865C0", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E62")]
      [Address(RVA = "0x11872F0", Offset = "0x11860F0", VA = "0x111872F0")]
      private IEnumerator SetDropStone(GameObject obj, int count) => (IEnumerator) null;

      [Token(Token = "0x6003E63")]
      [Address(RVA = "0x11866C0", Offset = "0x11854C0", VA = "0x111866C0")]
      private void CreateDropStone(GameObject gobj, Vector3 pos, int num)
      {
      }

      [Token(Token = "0x6003E64")]
      [Address(RVA = "0x11868E0", Offset = "0x11856E0", VA = "0x111868E0")]
      private IEnumerator CreateDropStone(GameObject obj, int count) => (IEnumerator) null;

      [Token(Token = "0x6003E65")]
      [Address(RVA = "0x1186960", Offset = "0x1185760", VA = "0x11186960")]
      private void SetDropStoneTexture(GameObject obj, GachaDropData drop, bool isCoin = true)
      {
      }

      [Token(Token = "0x6003E66")]
      [Address(RVA = "0x1187370", Offset = "0x1186170", VA = "0x11187370")]
      public State_SettingDropStone()
      {
      }
    }

    [Token(Token = "0x2000EF6")]
    private class State_WaitDropStoneS : State<GachaController>
    {
      [Token(Token = "0x6003E73")]
      [Address(RVA = "0x1187860", Offset = "0x1186660", VA = "0x11187860", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E74")]
      [Address(RVA = "0x11878D0", Offset = "0x11866D0", VA = "0x111878D0", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003E75")]
      [Address(RVA = "0x1187930", Offset = "0x1186730", VA = "0x11187930")]
      public State_WaitDropStoneS()
      {
      }
    }

    [Token(Token = "0x2000EF7")]
    private class State_WaitDropStone : State<GachaController>
    {
      [Token(Token = "0x4002E67")]
      [FieldOffset(Offset = "0xC")]
      private float mNextStateTime;
      [Token(Token = "0x4002E68")]
      [FieldOffset(Offset = "0x10")]
      private bool mAllActivated;
      [Token(Token = "0x4002E69")]
      [FieldOffset(Offset = "0x14")]
      private float mWaitTime;

      [Token(Token = "0x6003E76")]
      [Address(RVA = "0x1187970", Offset = "0x1186770", VA = "0x11187970", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E77")]
      [Address(RVA = "0x11879F0", Offset = "0x11867F0", VA = "0x111879F0")]
      private IEnumerator SetActiveDropStone() => (IEnumerator) null;

      [Token(Token = "0x6003E78")]
      [Address(RVA = "0x1187A60", Offset = "0x1186860", VA = "0x11187A60", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003E79")]
      [Address(RVA = "0x1187AF0", Offset = "0x11868F0", VA = "0x11187AF0")]
      public State_WaitDropStone()
      {
      }
    }

    [Token(Token = "0x2000EF9")]
    private class State_MoveDropStone : State<GachaController>
    {
      [Token(Token = "0x4002E6E")]
      [FieldOffset(Offset = "0xC")]
      private GameObject mStone;
      [Token(Token = "0x4002E6F")]
      [FieldOffset(Offset = "0x10")]
      private float spd;
      [Token(Token = "0x4002E70")]
      [FieldOffset(Offset = "0x14")]
      private Vector3 mDestination;

      [Token(Token = "0x6003E80")]
      [Address(RVA = "0x11847F0", Offset = "0x11835F0", VA = "0x111847F0", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E81")]
      [Address(RVA = "0x1184930", Offset = "0x1183730", VA = "0x11184930", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003E82")]
      [Address(RVA = "0x1184D80", Offset = "0x1183B80", VA = "0x11184D80")]
      public State_MoveDropStone()
      {
      }
    }

    [Token(Token = "0x2000EFA")]
    private class State_OpenDropStone : State<GachaController>
    {
      [Token(Token = "0x4002E71")]
      [FieldOffset(Offset = "0xC")]
      private GameObject mStone;
      [Token(Token = "0x4002E72")]
      [FieldOffset(Offset = "0x10")]
      private Animator at;

      [Token(Token = "0x6003E83")]
      [Address(RVA = "0x1185AA0", Offset = "0x11848A0", VA = "0x11185AA0", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E84")]
      [Address(RVA = "0x1185DD0", Offset = "0x1184BD0", VA = "0x11185DD0", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003E85")]
      [Address(RVA = "0x1185E70", Offset = "0x1184C70", VA = "0x11185E70")]
      public State_OpenDropStone()
      {
      }
    }

    [Token(Token = "0x2000EFB")]
    private class State_DestroyDropStone : State<GachaController>
    {
      [Token(Token = "0x6003E86")]
      [Address(RVA = "0x1183600", Offset = "0x1182400", VA = "0x11183600", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E87")]
      [Address(RVA = "0x11836E0", Offset = "0x11824E0", VA = "0x111836E0")]
      public State_DestroyDropStone()
      {
      }
    }

    [Token(Token = "0x2000EFC")]
    private class State_ActionRevolver : State<GachaController>
    {
      [Token(Token = "0x4002E73")]
      [FieldOffset(Offset = "0xC")]
      private Vector3 mNewAngle;
      [Token(Token = "0x4002E74")]
      [FieldOffset(Offset = "0x18")]
      private float mMoveSpeed;
      [Token(Token = "0x4002E75")]
      [FieldOffset(Offset = "0x1C")]
      private float mTheta;

      [Token(Token = "0x6003E88")]
      [Address(RVA = "0x1182C40", Offset = "0x1181A40", VA = "0x11182C40", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E89")]
      [Address(RVA = "0x1182D40", Offset = "0x1181B40", VA = "0x11182D40", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003E8A")]
      [Address(RVA = "0x1182F40", Offset = "0x1181D40", VA = "0x11182F40")]
      public State_ActionRevolver()
      {
      }
    }

    [Token(Token = "0x2000EFD")]
    private class State_EnableDropMaterial : State<GachaController>
    {
      [Token(Token = "0x6003E8B")]
      [Address(RVA = "0x1183D50", Offset = "0x1182B50", VA = "0x11183D50", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E8C")]
      [Address(RVA = "0x1184100", Offset = "0x1182F00", VA = "0x11184100")]
      public State_EnableDropMaterial()
      {
      }
    }

    [Token(Token = "0x2000EFE")]
    private class State_OpenDropMaterial : State<GachaController>
    {
      [Token(Token = "0x4002E76")]
      [FieldOffset(Offset = "0xC")]
      private GameObject go;
      [Token(Token = "0x4002E77")]
      [FieldOffset(Offset = "0x10")]
      private string[] ShardAnimList;

      [Token(Token = "0x6003E8D")]
      [Address(RVA = "0x1185430", Offset = "0x1184230", VA = "0x11185430", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E8E")]
      [Address(RVA = "0x1185530", Offset = "0x1184330", VA = "0x11185530", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003E8F")]
      [Address(RVA = "0x1185670", Offset = "0x1184470", VA = "0x11185670")]
      public State_OpenDropMaterial()
      {
      }
    }

    [Token(Token = "0x2000EFF")]
    private class State_WaitGaugeAnimation : State<GachaController>
    {
      [Token(Token = "0x4002E78")]
      [FieldOffset(Offset = "0xC")]
      private GachaUnitShard unitshard;

      [Token(Token = "0x6003E90")]
      [Address(RVA = "0x1187E50", Offset = "0x1186C50", VA = "0x11187E50", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E91")]
      [Address(RVA = "0x1187F80", Offset = "0x1186D80", VA = "0x11187F80")]
      private void MoveNextPhase()
      {
      }

      [Token(Token = "0x6003E92")]
      [Address(RVA = "0x1188140", Offset = "0x1186F40", VA = "0x11188140", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003E93")]
      [Address(RVA = "0x11882E0", Offset = "0x11870E0", VA = "0x111882E0")]
      public State_WaitGaugeAnimation()
      {
      }
    }

    [Token(Token = "0x2000F00")]
    private class State_WaitDropMaterial : State<GachaController>
    {
      [Token(Token = "0x6003E94")]
      [Address(RVA = "0x1187750", Offset = "0x1186550", VA = "0x11187750", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E95")]
      [Address(RVA = "0x1187780", Offset = "0x1186580", VA = "0x11187780", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003E96")]
      [Address(RVA = "0x1187820", Offset = "0x1186620", VA = "0x11187820")]
      public State_WaitDropMaterial()
      {
      }
    }

    [Token(Token = "0x2000F01")]
    private class State_CheckCardUnit : State<GachaController>
    {
      [Token(Token = "0x6003E97")]
      [Address(RVA = "0x1182F80", Offset = "0x1181D80", VA = "0x11182F80", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E98")]
      [Address(RVA = "0x1183010", Offset = "0x1181E10", VA = "0x11183010")]
      public State_CheckCardUnit()
      {
      }
    }

    [Token(Token = "0x2000F02")]
    private class State_CloseAnimDropMaterial : State<GachaController>
    {
      [Token(Token = "0x4002E79")]
      [FieldOffset(Offset = "0xC")]
      private Animator m_OpenMaterial;

      [Token(Token = "0x6003E99")]
      [Address(RVA = "0x1183430", Offset = "0x1182230", VA = "0x11183430", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E9A")]
      [Address(RVA = "0x1183500", Offset = "0x1182300", VA = "0x11183500", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003E9B")]
      [Address(RVA = "0x11835C0", Offset = "0x11823C0", VA = "0x111835C0")]
      public State_CloseAnimDropMaterial()
      {
      }
    }

    [Token(Token = "0x2000F03")]
    private class State_WaitCardAnim : State<GachaController>
    {
      [Token(Token = "0x6003E9C")]
      [Address(RVA = "0x11876A0", Offset = "0x11864A0", VA = "0x111876A0", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003E9D")]
      [Address(RVA = "0x1187710", Offset = "0x1186510", VA = "0x11187710")]
      public State_WaitCardAnim()
      {
      }
    }

    [Token(Token = "0x2000F04")]
    private class State_ResetCardAnim : State<GachaController>
    {
      [Token(Token = "0x6003E9E")]
      [Address(RVA = "0x11860A0", Offset = "0x1184EA0", VA = "0x111860A0", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003E9F")]
      [Address(RVA = "0x11860C0", Offset = "0x1184EC0", VA = "0x111860C0", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003EA0")]
      [Address(RVA = "0x1186120", Offset = "0x1184F20", VA = "0x11186120")]
      public State_ResetCardAnim()
      {
      }
    }

    [Token(Token = "0x2000F05")]
    private class State_SettingDisableDropMaterial : State<GachaController>
    {
      [Token(Token = "0x6003EA1")]
      [Address(RVA = "0x1186320", Offset = "0x1185120", VA = "0x11186320", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003EA2")]
      [Address(RVA = "0x11864F0", Offset = "0x11852F0", VA = "0x111864F0")]
      public State_SettingDisableDropMaterial()
      {
      }
    }

    [Token(Token = "0x2000F06")]
    private class State_DisableDropMaterial : State<GachaController>
    {
      [Token(Token = "0x6003EA3")]
      [Address(RVA = "0x1183B50", Offset = "0x1182950", VA = "0x11183B50", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003EA4")]
      [Address(RVA = "0x1183D10", Offset = "0x1182B10", VA = "0x11183D10")]
      public State_DisableDropMaterial()
      {
      }
    }

    [Token(Token = "0x2000F07")]
    private class State_NextDropAnimation : State<GachaController>
    {
      [Token(Token = "0x6003EA5")]
      [Address(RVA = "0x1184E00", Offset = "0x1183C00", VA = "0x11184E00", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003EA6")]
      [Address(RVA = "0x1184E30", Offset = "0x1183C30", VA = "0x11184E30", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003EA7")]
      [Address(RVA = "0x1184EC0", Offset = "0x1183CC0", VA = "0x11184EC0")]
      public State_NextDropAnimation()
      {
      }
    }

    [Token(Token = "0x2000F08")]
    private class State_CheckDropStone : State<GachaController>
    {
      [Token(Token = "0x6003EA8")]
      [Address(RVA = "0x1183050", Offset = "0x1181E50", VA = "0x11183050", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003EA9")]
      [Address(RVA = "0x11830E0", Offset = "0x1181EE0", VA = "0x111830E0")]
      public State_CheckDropStone()
      {
      }
    }

    [Token(Token = "0x2000F09")]
    private class State_WaitEndInput : State<GachaController>
    {
      [Token(Token = "0x6003EAA")]
      [Address(RVA = "0x1187D10", Offset = "0x1186B10", VA = "0x11187D10", Slot = "5")]
      public override void Update(GachaController self)
      {
      }

      [Token(Token = "0x6003EAB")]
      [Address(RVA = "0x1187D70", Offset = "0x1186B70", VA = "0x11187D70")]
      public State_WaitEndInput()
      {
      }
    }

    [Token(Token = "0x2000F0A")]
    private class State_EndSetting : State<GachaController>
    {
      [Token(Token = "0x6003EAC")]
      [Address(RVA = "0x1184140", Offset = "0x1182F40", VA = "0x11184140", Slot = "4")]
      public override void Begin(GachaController self)
      {
      }

      [Token(Token = "0x6003EAD")]
      [Address(RVA = "0x1184280", Offset = "0x1183080", VA = "0x11184280")]
      public State_EndSetting()
      {
      }
    }

    [Token(Token = "0x2000F0B")]
    private enum PickupAnimType : byte
    {
      [Token(Token = "0x4002E7B")] None,
      [Token(Token = "0x4002E7C")] Pickup,
      [Token(Token = "0x4002E7D")] PickupUseAnim,
    }
  }
}

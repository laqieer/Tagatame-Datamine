// Decompiled with JetBrains decompiler
// Type: SRPG.UnitController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E11")]
  public abstract class UnitController : AnimationPlayer
  {
    [Token(Token = "0x4002A1E")]
    public const string CharacterAnimationDir = "CHM/";
    [Token(Token = "0x4002A1F")]
    [FieldOffset(Offset = "0x68")]
    private UnitData mUnitData;
    [Token(Token = "0x4002A20")]
    [FieldOffset(Offset = "0x6C")]
    private string mCharacterID;
    [Token(Token = "0x4002A21")]
    [FieldOffset(Offset = "0x70")]
    private string mJobID;
    [Token(Token = "0x4002A22")]
    [FieldOffset(Offset = "0x74")]
    private string mJobResourceID;
    [Token(Token = "0x4002A23")]
    [FieldOffset(Offset = "0x78")]
    protected CharacterDB.Job mCharacterData;
    [Token(Token = "0x4002A24")]
    [FieldOffset(Offset = "0x7C")]
    private bool mSetupStarted;
    [Token(Token = "0x4002A25")]
    [FieldOffset(Offset = "0x80")]
    private int mNumLoadRequests;
    [Token(Token = "0x4002A26")]
    [FieldOffset(Offset = "0x84")]
    private GameObject mUnitObject;
    [Token(Token = "0x4002A27")]
    [FieldOffset(Offset = "0x88")]
    protected CharacterSettings mCharacterSettings;
    [Token(Token = "0x4002A28")]
    [FieldOffset(Offset = "0x8C")]
    public Color32 VesselColor;
    [Token(Token = "0x4002A29")]
    [FieldOffset(Offset = "0x90")]
    public float VesselStrength;
    [Token(Token = "0x4002A2A")]
    [FieldOffset(Offset = "0x94")]
    private GameObject mPrimaryEquipment;
    [Token(Token = "0x4002A2B")]
    [FieldOffset(Offset = "0x98")]
    private GameObject mSecondaryEquipment;
    [Token(Token = "0x4002A2C")]
    [FieldOffset(Offset = "0x9C")]
    private GameObject mTertiaryEquipment;
    [Token(Token = "0x4002A2D")]
    [FieldOffset(Offset = "0xA0")]
    private List<GameObject> mPrimaryEquipmentChangeLists;
    [Token(Token = "0x4002A2E")]
    [FieldOffset(Offset = "0xA4")]
    private List<GameObject> mSecondaryEquipmentChangeLists;
    [Token(Token = "0x4002A2F")]
    [FieldOffset(Offset = "0xA8")]
    private List<GameObject> mTertiaryEquipmentChangeLists;
    [Token(Token = "0x4002A30")]
    [FieldOffset(Offset = "0xAC")]
    private GameObject mPrimaryEquipmentDefault;
    [Token(Token = "0x4002A31")]
    [FieldOffset(Offset = "0xB0")]
    private GameObject mSecondaryEquipmentDefault;
    [Token(Token = "0x4002A32")]
    [FieldOffset(Offset = "0xB4")]
    private GameObject mTertiaryEquipmentDefault;
    [Token(Token = "0x4002A33")]
    [FieldOffset(Offset = "0xB8")]
    private bool mUseSubEquipment;
    [Token(Token = "0x4002A34")]
    [FieldOffset(Offset = "0xBC")]
    private GameObject mSubPrimaryEquipment;
    [Token(Token = "0x4002A35")]
    [FieldOffset(Offset = "0xC0")]
    private GameObject mSubSecondaryEquipment;
    [Token(Token = "0x4002A36")]
    [FieldOffset(Offset = "0xC4")]
    private GameObject mSubTertiaryEquipment;
    [Token(Token = "0x4002A37")]
    [FieldOffset(Offset = "0xC8")]
    private List<GameObject> mSubPrimaryEquipmentChangeLists;
    [Token(Token = "0x4002A38")]
    [FieldOffset(Offset = "0xCC")]
    private List<GameObject> mSubSecondaryEquipmentChangeLists;
    [Token(Token = "0x4002A39")]
    [FieldOffset(Offset = "0xD0")]
    private List<GameObject> mSubTertiaryEquipmentChangeLists;
    [Token(Token = "0x4002A3A")]
    [FieldOffset(Offset = "0xD4")]
    private GameObject mSubPrimaryEquipmentDefault;
    [Token(Token = "0x4002A3B")]
    [FieldOffset(Offset = "0xD8")]
    private GameObject mSubSecondaryEquipmentDefault;
    [Token(Token = "0x4002A3C")]
    [FieldOffset(Offset = "0xDC")]
    private GameObject mSubTertiaryEquipmentDefault;
    [Token(Token = "0x4002A3D")]
    [FieldOffset(Offset = "0xE0")]
    private FaceAnimation mFaceAnimation;
    [Token(Token = "0x4002A3E")]
    [FieldOffset(Offset = "0xE4")]
    private bool mPlayingFaceAnimation;
    [Token(Token = "0x4002A3F")]
    [FieldOffset(Offset = "0xE5")]
    public bool LoadEquipments;
    [Token(Token = "0x4002A40")]
    [FieldOffset(Offset = "0xE6")]
    public bool KeepUnitHidden;
    [Token(Token = "0x4002A41")]
    [FieldOffset(Offset = "0xE8")]
    protected List<Material> CharacterMaterials;
    [Token(Token = "0x4002A42")]
    [FieldOffset(Offset = "0xEC")]
    protected List<Material> AlphaBlendMaterials;
    [Token(Token = "0x4002A43")]
    [FieldOffset(Offset = "0xF0")]
    protected List<CharacterDB.Job> mCharacterDataLists;
    [Token(Token = "0x4002A44")]
    [FieldOffset(Offset = "0xF4")]
    protected List<GameObject> mUnitObjectLists;
    [Token(Token = "0x4002A45")]
    [FieldOffset(Offset = "0xF8")]
    protected List<CharacterSettings> mCharacterSettingsLists;
    [Token(Token = "0x4002A46")]
    [FieldOffset(Offset = "0xFC")]
    protected List<FaceAnimation> mFaceAnimationLists;
    [Token(Token = "0x4002A47")]
    [FieldOffset(Offset = "0x100")]
    private Color UnitColor;
    [Token(Token = "0x4002A48")]
    [FieldOffset(Offset = "0x110")]
    private List<GameObject> mGoRidingModelList;
    [Token(Token = "0x4002A49")]
    public const string COLLABO_SKILL_ASSET_PREFIX = "D";
    [Token(Token = "0x4002A4A")]
    [FieldOffset(Offset = "0x114")]
    private float mVesselStrength;
    [Token(Token = "0x4002A4B")]
    [FieldOffset(Offset = "0x118")]
    private float mVesselAnimTime;
    [Token(Token = "0x4002A4C")]
    [FieldOffset(Offset = "0x11C")]
    private float mVesselAnimDuration;
    [Token(Token = "0x4002A4D")]
    [FieldOffset(Offset = "0x120")]
    private float mVesselAnimStart;
    [Token(Token = "0x4002A4E")]
    [FieldOffset(Offset = "0x124")]
    private float mVesselAnimEnd;

    [Token(Token = "0x17000416")]
    public CharacterDB.Job CharacterData
    {
      [Token(Token = "0x60039BD"), Address(RVA = "0x349370", Offset = "0x348170", VA = "0x10349370")] get
      {
        return (CharacterDB.Job) null;
      }
    }

    [Token(Token = "0x17000417")]
    protected RigSetup Rig
    {
      [Token(Token = "0x60039BE"), Address(RVA = "0x10C8880", Offset = "0x10C7680", VA = "0x110C8880")] get
      {
        return (RigSetup) null;
      }
    }

    [Token(Token = "0x17000418")]
    public float Height
    {
      [Token(Token = "0x60039BF"), Address(RVA = "0x10C87B0", Offset = "0x10C75B0", VA = "0x110C87B0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000419")]
    public Vector3 CenterPosition
    {
      [Token(Token = "0x60039C0"), Address(RVA = "0x10C84D0", Offset = "0x10C72D0", VA = "0x110C84D0")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x1700041A")]
    public GameObject UnitObject
    {
      [Token(Token = "0x60039C1"), Address(RVA = "0x2B6020", Offset = "0x2B4E20", VA = "0x102B6020")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x1700041B")]
    public float UIDispOffset
    {
      [Token(Token = "0x60039C2"), Address(RVA = "0x10C8910", Offset = "0x10C7710", VA = "0x110C8910")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700041C")]
    public Vector3 UIDispPosition
    {
      [Token(Token = "0x60039C3"), Address(RVA = "0x10C8980", Offset = "0x10C7780", VA = "0x110C8980")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x1700041D")]
    public List<GameObject> GoRidingModelList
    {
      [Token(Token = "0x60039C4"), Address(RVA = "0x10C85B0", Offset = "0x10C73B0", VA = "0x110C85B0")] get
      {
        return (List<GameObject>) null;
      }
    }

    [Token(Token = "0x1700041E")]
    public UnitData UnitData
    {
      [Token(Token = "0x60039C5"), Address(RVA = "0x349350", Offset = "0x348150", VA = "0x10349350")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x1700041F")]
    protected bool UseSubEquipment
    {
      [Token(Token = "0x60039C6"), Address(RVA = "0x10C8AC0", Offset = "0x10C78C0", VA = "0x110C8AC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000420")]
    public override bool IsLoading
    {
      [Token(Token = "0x60039C7"), Address(RVA = "0x10C8850", Offset = "0x10C7650", VA = "0x110C8850", Slot = "14")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60039C8")]
    [Address(RVA = "0x10C2130", Offset = "0x10C0F30", VA = "0x110C2130")]
    protected void AddLoadThreadCount()
    {
    }

    [Token(Token = "0x60039C9")]
    [Address(RVA = "0x10C3230", Offset = "0x10C2030", VA = "0x110C3230")]
    protected void RemoveLoadThreadCount()
    {
    }

    [Token(Token = "0x60039CA")]
    [Address(RVA = "0x10C44E0", Offset = "0x10C32E0", VA = "0x110C44E0")]
    public bool SetActivateUnitObject(int idx) => new bool();

    [Token(Token = "0x60039CB")]
    [Address(RVA = "0x10C6E50", Offset = "0x10C5C50", VA = "0x110C6E50", Slot = "4")]
    protected override void Start()
    {
    }

    [Token(Token = "0x60039CC")]
    [Address(RVA = "0x10C2670", Offset = "0x10C1470", VA = "0x110C2670", Slot = "16")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x60039CD")]
    [Address(RVA = "0x10C8400", Offset = "0x10C7200", VA = "0x110C8400")]
    private void createRootBoneList(Transform Root, ref List<Transform> Dest)
    {
    }

    [Token(Token = "0x60039CE")]
    [Address(RVA = "0x10C2F90", Offset = "0x10C1D90", VA = "0x110C2F90")]
    private void ReleaseMaterials()
    {
    }

    [Token(Token = "0x60039CF")]
    [Address(RVA = "0x10C2B10", Offset = "0x10C1910", VA = "0x110C2B10", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x60039D0")]
    [Address(RVA = "0x10C7E60", Offset = "0x10C6C60", VA = "0x110C7E60")]
    private void UpdateFaceAnimation()
    {
    }

    [Token(Token = "0x60039D1")]
    [Address(RVA = "0x10C6CE0", Offset = "0x10C5AE0", VA = "0x110C6CE0", Slot = "17")]
    public virtual void SetupUnit(UnitData unitData, int jobIndex = -1)
    {
    }

    [Token(Token = "0x60039D2")]
    [Address(RVA = "0x10C6DC0", Offset = "0x10C5BC0", VA = "0x110C6DC0", Slot = "18")]
    public virtual void SetupUnit(string unitID, string jobID)
    {
    }

    [Token(Token = "0x60039D3")]
    [Address(RVA = "0x10C24C0", Offset = "0x10C12C0", VA = "0x110C24C0")]
    protected Transform GetCharacterRoot() => (Transform) null;

    [Token(Token = "0x17000421")]
    protected virtual ESex Sex
    {
      [Token(Token = "0x60039D4"), Address(RVA = "0x10C88F0", Offset = "0x10C76F0", VA = "0x110C88F0", Slot = "19")] get
      {
        return new ESex();
      }
    }

    [Token(Token = "0x60039D5")]
    [Address(RVA = "0x10C6B20", Offset = "0x10C5920", VA = "0x110C6B20")]
    public void SetVisible(bool visible)
    {
    }

    [Token(Token = "0x60039D6")]
    [Address(RVA = "0x10C2600", Offset = "0x10C1400", VA = "0x110C2600")]
    public bool IsVisible() => new bool();

    [Token(Token = "0x60039D7")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "20")]
    protected virtual void OnVisibilityChange(bool visible)
    {
    }

    [Token(Token = "0x60039D8")]
    [Address(RVA = "0x10C2830", Offset = "0x10C1630", VA = "0x110C2830")]
    public void LoadUnitAnimationAsync(
      string id,
      string animationName,
      bool addJobName,
      bool is_collabo_skill = false)
    {
    }

    [Token(Token = "0x60039D9")]
    [Address(RVA = "0x10C2AA0", Offset = "0x10C18A0", VA = "0x110C2AA0")]
    public void LoadUnitCommonAnimAsync(string id, string playAnimName, SkillParam _param)
    {
    }

    [Token(Token = "0x60039DA")]
    private LoadRequest LoadResource<T>(string path) => (LoadRequest) null;

    [Token(Token = "0x60039DB")]
    [Address(RVA = "0x10C4B10", Offset = "0x10C3910", VA = "0x110C4B10")]
    private void SetMaterialColor(List<Material> materials, Color color)
    {
    }

    [Token(Token = "0x60039DC")]
    [Address(RVA = "0x10C4BD0", Offset = "0x10C39D0", VA = "0x110C4BD0")]
    protected void SetMaterialsWriteColorMask(GameObject go, ColorWriteMask mask)
    {
    }

    [Token(Token = "0x60039DD")]
    [Address(RVA = "0x10C25E0", Offset = "0x10C13E0", VA = "0x110C25E0")]
    public Color GetColor() => new Color();

    [Token(Token = "0x60039DE")]
    [Address(RVA = "0x10C49B0", Offset = "0x10C37B0", VA = "0x110C49B0")]
    public void SetColor(Color color)
    {
    }

    [Token(Token = "0x60039DF")]
    [Address(RVA = "0x10C2730", Offset = "0x10C1530", VA = "0x110C2730")]
    public bool LoadAddModels(int job_index) => new bool();

    [Token(Token = "0x60039E0")]
    [Address(RVA = "0x10C21A0", Offset = "0x10C0FA0", VA = "0x110C21A0")]
    private IEnumerator AsyncSetup(CharacterDB.Character ch, int jobIndex) => (IEnumerator) null;

    [Token(Token = "0x60039E1")]
    [Address(RVA = "0x10C32C0", Offset = "0x10C20C0", VA = "0x110C32C0")]
    public static void RenamePrimary(EquipmentSet equip, GameObject go)
    {
    }

    [Token(Token = "0x60039E2")]
    [Address(RVA = "0x10C3370", Offset = "0x10C2170", VA = "0x110C3370")]
    public static void RenameSecondary(EquipmentSet equip, GameObject go)
    {
    }

    [Token(Token = "0x60039E3")]
    [Address(RVA = "0x10C3420", Offset = "0x10C2220", VA = "0x110C3420")]
    public static void RenameTertiary(EquipmentSet equip, GameObject go)
    {
    }

    [Token(Token = "0x60039E4")]
    [Address(RVA = "0x10C1FB0", Offset = "0x10C0DB0", VA = "0x110C1FB0")]
    protected void ActivateRidingModelByJob()
    {
    }

    [Token(Token = "0x60039E5")]
    [Address(RVA = "0x10C2360", Offset = "0x10C1160", VA = "0x110C2360")]
    private void FindCharacterMaterials()
    {
    }

    [Token(Token = "0x60039E6")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "21")]
    protected virtual void PostSetup()
    {
    }

    [Token(Token = "0x60039E7")]
    [Address(RVA = "0x10C4AC0", Offset = "0x10C38C0", VA = "0x110C4AC0")]
    public void SetEquipmentsVisible(bool visible)
    {
    }

    [Token(Token = "0x60039E8")]
    [Address(RVA = "0x10C4DA0", Offset = "0x10C3BA0", VA = "0x110C4DA0")]
    public void SetPrimaryEquipmentsVisible(bool visible)
    {
    }

    [Token(Token = "0x60039E9")]
    [Address(RVA = "0x10C4E30", Offset = "0x10C3C30", VA = "0x110C4E30")]
    public void SetSecondaryEquipmentsVisible(bool visible)
    {
    }

    [Token(Token = "0x60039EA")]
    [Address(RVA = "0x10C6560", Offset = "0x10C5360", VA = "0x110C6560")]
    public void SetTertiaryEquipmentsVisible(bool visible)
    {
    }

    [Token(Token = "0x60039EB")]
    [Address(RVA = "0x10C77C0", Offset = "0x10C65C0", VA = "0x110C77C0")]
    public void SwitchEquipmentLists(EquipmentSet.EquipmentPlace type, int no)
    {
    }

    [Token(Token = "0x60039EC")]
    [Address(RVA = "0x10C39D0", Offset = "0x10C27D0", VA = "0x110C39D0")]
    public void ResetEquipmentLists(EquipmentSet.EquipmentPlace type)
    {
    }

    [Token(Token = "0x60039ED")]
    [Address(RVA = "0x10C4860", Offset = "0x10C3660", VA = "0x110C4860")]
    private void SetAttachmentParent(GameObject go, Transform parent)
    {
    }

    [Token(Token = "0x60039EE")]
    [Address(RVA = "0x10C71A0", Offset = "0x10C5FA0", VA = "0x110C71A0")]
    public void SwitchAttachmentLists(EquipmentSet.EquipmentPlace type, int no)
    {
    }

    [Token(Token = "0x60039EF")]
    [Address(RVA = "0x10C34D0", Offset = "0x10C22D0", VA = "0x110C34D0")]
    public void ResetAttachmentLists(EquipmentSet.EquipmentPlace type)
    {
    }

    [Token(Token = "0x60039F0")]
    [Address(RVA = "0x10C4EC0", Offset = "0x10C3CC0", VA = "0x110C4EC0")]
    public void SetSubEquipment(
      EquipmentSet primary_equip,
      EquipmentSet secondary_equip,
      EquipmentSet tertiary_equip,
      bool hidden = false)
    {
    }

    [Token(Token = "0x60039F1")]
    [Address(RVA = "0x10C4AF0", Offset = "0x10C38F0", VA = "0x110C4AF0")]
    private void SetMaterialByGameObject(GameObject materialObject)
    {
    }

    [Token(Token = "0x60039F2")]
    [Address(RVA = "0x10C32A0", Offset = "0x10C20A0", VA = "0x110C32A0")]
    private void RemoveMaterialByGameObject(GameObject materialObject)
    {
    }

    [Token(Token = "0x60039F3")]
    [Address(RVA = "0x10C2220", Offset = "0x10C1020", VA = "0x110C2220")]
    private void ControlMaterialByGameObject(bool isSet, GameObject materialObject)
    {
    }

    [Token(Token = "0x60039F4")]
    [Address(RVA = "0x10C7AB0", Offset = "0x10C68B0", VA = "0x110C7AB0")]
    public void SwitchEquipments()
    {
    }

    [Token(Token = "0x60039F5")]
    [Address(RVA = "0x10C6840", Offset = "0x10C5640", VA = "0x110C6840")]
    public void SetVisibleEquipments(bool is_visible)
    {
    }

    [Token(Token = "0x60039F6")]
    [Address(RVA = "0x10C69B0", Offset = "0x10C57B0", VA = "0x110C69B0")]
    public void SetVisibleSubEquipments(bool is_visible)
    {
    }

    [Token(Token = "0x60039F7")]
    [Address(RVA = "0x10C3CC0", Offset = "0x10C2AC0", VA = "0x110C3CC0")]
    public void ResetSubEquipments()
    {
    }

    [Token(Token = "0x60039F8")]
    [Address(RVA = "0x10C65F0", Offset = "0x10C53F0", VA = "0x110C65F0")]
    private void SetVesselStrength(float strength)
    {
    }

    [Token(Token = "0x60039F9")]
    [Address(RVA = "0x10C2140", Offset = "0x10C0F40", VA = "0x110C2140")]
    public void AnimateVessel(float desiredStrength, float duration)
    {
    }

    [Token(Token = "0x60039FA")]
    [Address(RVA = "0x10C8050", Offset = "0x10C6E50", VA = "0x110C8050")]
    private void UpdateVesselAnimation()
    {
    }

    [Token(Token = "0x60039FB")]
    [Address(RVA = "0x10C80F0", Offset = "0x10C6EF0", VA = "0x110C80F0")]
    protected UnitController()
    {
    }
  }
}

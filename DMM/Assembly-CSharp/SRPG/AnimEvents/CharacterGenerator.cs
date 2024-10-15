// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.CharacterGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032FF")]
  public class CharacterGenerator : AnimEventWithTarget
  {
    [Token(Token = "0x400EFE2")]
    private const string WpnPath = "Equipments/";
    [Token(Token = "0x400EFE3")]
    private const string BodyTexturePath = "CH/BODYTEX/";
    [Token(Token = "0x400EFE4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private bool Attach;
    [Token(Token = "0x400EFE5")]
    [FieldOffset(Offset = "0x3C")]
    [StringIsCharacterDBList]
    [SerializeField]
    private string UnitID;
    [Token(Token = "0x400EFE6")]
    [FieldOffset(Offset = "0x40")]
    [ReadOnly]
    [SerializeField]
    private GameObject Body;
    [Token(Token = "0x400EFE7")]
    [FieldOffset(Offset = "0x44")]
    [ReadOnly]
    [SerializeField]
    private Texture2D BodyTexture;
    [Token(Token = "0x400EFE8")]
    [FieldOffset(Offset = "0x48")]
    [ReadOnly]
    [SerializeField]
    private GameObject BodyAttachment;
    [Token(Token = "0x400EFE9")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    [ReadOnly]
    private GameObject HeadAttachment;
    [Token(Token = "0x400EFEA")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    [ReadOnly]
    private GameObject Head;
    [Token(Token = "0x400EFEB")]
    [FieldOffset(Offset = "0x54")]
    [ReadOnly]
    [SerializeField]
    private GameObject Hair;
    [Token(Token = "0x400EFEC")]
    [FieldOffset(Offset = "0x58")]
    [ReadOnly]
    [SerializeField]
    private EquipmentSet Equip;
    [Token(Token = "0x400EFED")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    [StringIsResourcePath(typeof (UnityEngine.Object), "CH/BODY/", "デフォルト")]
    private string BodyName;
    [Token(Token = "0x400EFEE")]
    [FieldOffset(Offset = "0x60")]
    [StringIsResourcePath(typeof (Texture2D), "CH/BODYTEX/", "デフォルト")]
    [SerializeField]
    private string BodyTextureName;
    [Token(Token = "0x400EFEF")]
    [FieldOffset(Offset = "0x64")]
    [StringIsResourcePath(typeof (Texture2D), "CH/BODYOPT/", "デフォルト")]
    [SerializeField]
    private string BodyAttachmentName;
    [Token(Token = "0x400EFF0")]
    [FieldOffset(Offset = "0x68")]
    [StringIsResourcePath(typeof (UnityEngine.Object), "CH/HEAD/", "デフォルト")]
    [SerializeField]
    private string HeadName;
    [Token(Token = "0x400EFF1")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    [StringIsResourcePath(typeof (UnityEngine.Object), "CH/HAIR/", "デフォルト")]
    private string HairName;
    [Token(Token = "0x400EFF2")]
    [FieldOffset(Offset = "0x70")]
    [StringIsResourcePath(typeof (UnityEngine.Object), "CH/HEADOPT/", "デフォルト")]
    [SerializeField]
    private string HeadAttachmentName;
    [Token(Token = "0x400EFF3")]
    [FieldOffset(Offset = "0x74")]
    [StringIsResourcePath(typeof (UnityEngine.Object), "Equipments/", "武器無し")]
    [SerializeField]
    private string WeaponName;
    [Token(Token = "0x400EFF4")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private bool DisableHeadAttachment;
    [Token(Token = "0x400EFF5")]
    [FieldOffset(Offset = "0x79")]
    [SerializeField]
    private bool DisableBodyAttachment;
    [Token(Token = "0x400EFF6")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private AnimDef AnimDef;
    [Token(Token = "0x400EFF7")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private bool LimLight;
    [Token(Token = "0x400EFF8")]
    [FieldOffset(Offset = "0x84")]
    [HideInInspector]
    public EUnitSide UnitSide;
    [Token(Token = "0x400EFF9")]
    [FieldOffset(Offset = "0x88")]
    private CharacterDB.Character mCharacter;
    [Token(Token = "0x400EFFA")]
    [FieldOffset(Offset = "0x8C")]
    private CharacterDB.Job mJob;
    [Token(Token = "0x400EFFB")]
    [FieldOffset(Offset = "0x90")]
    private GameObject mCharacterObject;
    [Token(Token = "0x400EFFC")]
    [FieldOffset(Offset = "0x94")]
    private GameObject mCharacterWpnR;
    [Token(Token = "0x400EFFD")]
    [FieldOffset(Offset = "0x98")]
    private GameObject mCharacterWpnL;
    [Token(Token = "0x400EFFE")]
    [FieldOffset(Offset = "0x9C")]
    private FaceAnimation mFaceAnimation;
    [Token(Token = "0x400EFFF")]
    [FieldOffset(Offset = "0xA0")]
    private GeneratedCharacter mGeneratedCharacter;
    [Token(Token = "0x400F000")]
    [FieldOffset(Offset = "0xA4")]
    private bool mPlayingFaceAnimation;

    [Token(Token = "0x17001D0A")]
    private GeneratedCharacter GeneratedCharacter
    {
      [Token(Token = "0x600DFCF"), Address(RVA = "0xA917F0", Offset = "0xA905F0", VA = "0x10A917F0")] get
      {
        return (GeneratedCharacter) null;
      }
    }

    [Token(Token = "0x600DFD0")]
    [Address(RVA = "0xA91010", Offset = "0xA8FE10", VA = "0x10A91010")]
    private void GeneratedCharacterDestroyed()
    {
    }

    [Token(Token = "0x600DFD1")]
    [Address(RVA = "0xA90B50", Offset = "0xA8F950", VA = "0x10A90B50")]
    private void Generate(GameObject parent_object)
    {
    }

    [Token(Token = "0x600DFD2")]
    [Address(RVA = "0xA91060", Offset = "0xA8FE60", VA = "0x10A91060", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DFD3")]
    [Address(RVA = "0xA91040", Offset = "0xA8FE40", VA = "0x10A91040", Slot = "6")]
    public override void OnEnd(GameObject go)
    {
    }

    [Token(Token = "0x600DFD4")]
    [Address(RVA = "0xA91100", Offset = "0xA8FF00", VA = "0x10A91100")]
    public void ResetAnimDef()
    {
    }

    [Token(Token = "0x600DFD5")]
    [Address(RVA = "0xA91220", Offset = "0xA90020", VA = "0x10A91220")]
    private void SetupLocation(GameObject go)
    {
    }

    [Token(Token = "0x17001D0B")]
    public GameObject CharacterObject
    {
      [Token(Token = "0x600DFD6"), Address(RVA = "0x3492D0", Offset = "0x3480D0", VA = "0x103492D0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17001D0C")]
    public AnimDef SetAnimDef
    {
      [Token(Token = "0x600DFD7"), Address(RVA = "0x2B5EF0", Offset = "0x2B4CF0", VA = "0x102B5EF0")] get
      {
        return (AnimDef) null;
      }
    }

    [Token(Token = "0x600DFD8")]
    [Address(RVA = "0xA91160", Offset = "0xA8FF60", VA = "0x10A91160")]
    public void SetAnimation(float adjust_time)
    {
    }

    [Token(Token = "0x600DFD9")]
    [Address(RVA = "0xA91070", Offset = "0xA8FE70", VA = "0x10A91070", Slot = "5")]
    public override void OnTick(GameObject go, float ratio)
    {
    }

    [Token(Token = "0x600DFDA")]
    [Address(RVA = "0xA91590", Offset = "0xA90390", VA = "0x10A91590")]
    private void UpdateFaceAnimation(float ratio)
    {
    }

    [Token(Token = "0x600DFDB")]
    [Address(RVA = "0xA90960", Offset = "0xA8F760", VA = "0x10A90960")]
    public void DestroyCharactr()
    {
    }

    [Token(Token = "0x600DFDC")]
    [Address(RVA = "0xA917D0", Offset = "0xA905D0", VA = "0x10A917D0")]
    public CharacterGenerator()
    {
    }
  }
}

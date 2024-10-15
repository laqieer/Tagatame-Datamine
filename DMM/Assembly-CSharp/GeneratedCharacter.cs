// Decompiled with JetBrains decompiler
// Type: GeneratedCharacter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000F7")]
[AddComponentMenu("Common/GeneratedCharacter")]
public class GeneratedCharacter : MonoBehaviour
{
  [Token(Token = "0x40004A3")]
  [FieldOffset(Offset = "0xC")]
  private FaceAnimation mFaceAnimation;
  [Token(Token = "0x40004A4")]
  [FieldOffset(Offset = "0x10")]
  private bool mPlayingFaceAnimation;
  [Token(Token = "0x40004A5")]
  [FieldOffset(Offset = "0x14")]
  public GeneratedCharacter.OnDestroyCharacter mDestroyCharacter;
  [Token(Token = "0x40004A6")]
  [FieldOffset(Offset = "0x18")]
  private Color32 VesselColor;
  [Token(Token = "0x40004A7")]
  [FieldOffset(Offset = "0x1C")]
  private Color UnitColor;
  [Token(Token = "0x40004A8")]
  [FieldOffset(Offset = "0x2C")]
  private bool mEnableStaticLight;
  [Token(Token = "0x40004A9")]
  [FieldOffset(Offset = "0x30")]
  private List<Material> mCharacterMaterials;
  [Token(Token = "0x40004AA")]
  [FieldOffset(Offset = "0x34")]
  private GameObject mPrimaryEquipment;
  [Token(Token = "0x40004AB")]
  [FieldOffset(Offset = "0x38")]
  private GameObject mSecondaryEquipment;
  [Token(Token = "0x40004AC")]
  [FieldOffset(Offset = "0x3C")]
  private GameObject mTertiaryEquipment;
  [Token(Token = "0x40004AD")]
  [FieldOffset(Offset = "0x40")]
  private List<GameObject> mPrimaryEquipmentChangeLists;
  [Token(Token = "0x40004AE")]
  [FieldOffset(Offset = "0x44")]
  private List<GameObject> mSecondaryEquipmentChangeLists;
  [Token(Token = "0x40004AF")]
  [FieldOffset(Offset = "0x48")]
  private List<GameObject> mTertiaryEquipmentChangeLists;
  [Token(Token = "0x40004B0")]
  [FieldOffset(Offset = "0x4C")]
  private GameObject mPrimaryEquipmentDefault;
  [Token(Token = "0x40004B1")]
  [FieldOffset(Offset = "0x50")]
  private GameObject mSecondaryEquipmentDefault;
  [Token(Token = "0x40004B2")]
  [FieldOffset(Offset = "0x54")]
  private GameObject mTertiaryEquipmentDefault;

  [Token(Token = "0x6000660")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void Start()
  {
  }

  [Token(Token = "0x6000661")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void Update()
  {
  }

  [Token(Token = "0x6000662")]
  [Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")]
  public void SetVesselColor(Color32 color)
  {
  }

  [Token(Token = "0x6000663")]
  [Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", VA = "0x104A9DB0")]
  public void EnableStaticLight(bool enable)
  {
  }

  [Token(Token = "0x17000102")]
  private List<Material> CharacterMaterials
  {
    [Token(Token = "0x6000664"), Address(RVA = "0xD58040", Offset = "0xD56E40", VA = "0x10D58040")] get
    {
      return (List<Material>) null;
    }
  }

  [Token(Token = "0x6000665")]
  [Address(RVA = "0xD552B0", Offset = "0xD540B0", VA = "0x10D552B0")]
  private void DestroyMaterials()
  {
  }

  [Token(Token = "0x6000666")]
  [Address(RVA = "0xD55ED0", Offset = "0xD54CD0", VA = "0x10D55ED0")]
  public void SetEquip(EquipmentSet Equip)
  {
  }

  [Token(Token = "0x6000667")]
  [Address(RVA = "0xD55AD0", Offset = "0xD548D0", VA = "0x10D55AD0")]
  public void ResetEquipmentLists(EquipmentSet.EquipmentPlace type)
  {
  }

  [Token(Token = "0x6000668")]
  [Address(RVA = "0xD55410", Offset = "0xD54210", VA = "0x10D55410")]
  private void FindCharacterMaterials()
  {
  }

  [Token(Token = "0x6000669")]
  [Address(RVA = "0xD55670", Offset = "0xD54470", VA = "0x10D55670")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600066A")]
  [Address(RVA = "0xD57420", Offset = "0xD56220", VA = "0x10D57420")]
  public void SetLim(bool enable)
  {
  }

  [Token(Token = "0x600066B")]
  [Address(RVA = "0xD57710", Offset = "0xD56510", VA = "0x10D57710")]
  private void SetMaterialColor(List<Material> materials, Color color)
  {
  }

  [Token(Token = "0x600066C")]
  [Address(RVA = "0xD57BF0", Offset = "0xD569F0", VA = "0x10D57BF0")]
  public void SetVisible(bool visible)
  {
  }

  [Token(Token = "0x600066D")]
  [Address(RVA = "0xD55650", Offset = "0xD54450", VA = "0x10D55650")]
  public Color GetColor() => new Color();

  [Token(Token = "0x600066E")]
  [Address(RVA = "0xD55DB0", Offset = "0xD54BB0", VA = "0x10D55DB0")]
  public void SetColor(Color color)
  {
  }

  [Token(Token = "0x600066F")]
  [Address(RVA = "0xD57950", Offset = "0xD56750", VA = "0x10D57950")]
  public void SetVesselStrength(float strength, GameObject go, float VesselStrength)
  {
  }

  [Token(Token = "0x6000670")]
  [Address(RVA = "0xD577D0", Offset = "0xD565D0", VA = "0x10D577D0")]
  public void SetPrimaryEquipmentsVisible(bool visible)
  {
  }

  [Token(Token = "0x6000671")]
  [Address(RVA = "0xD57850", Offset = "0xD56650", VA = "0x10D57850")]
  public void SetSecondaryEquipmentsVisible(bool visible)
  {
  }

  [Token(Token = "0x6000672")]
  [Address(RVA = "0xD578D0", Offset = "0xD566D0", VA = "0x10D578D0")]
  public void SetTertiaryEquipmentsVisible(bool visible)
  {
  }

  [Token(Token = "0x6000673")]
  [Address(RVA = "0xD57C80", Offset = "0xD56A80", VA = "0x10D57C80")]
  public void SwitchEquipmentLists(EquipmentSet.EquipmentPlace type, int no)
  {
  }

  [Token(Token = "0x6000674")]
  [Address(RVA = "0xD57F50", Offset = "0xD56D50", VA = "0x10D57F50")]
  public GeneratedCharacter()
  {
  }

  [Token(Token = "0x20000F8")]
  public delegate void OnDestroyCharacter();
}

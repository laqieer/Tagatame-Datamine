// Decompiled with JetBrains decompiler
// Type: EquipmentSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000DA")]
public class EquipmentSet : ScriptableObject
{
  [Token(Token = "0x40003BD")]
  [FieldOffset(Offset = "0xC")]
  public EquipmentSet.EquipmentType Type;
  [Token(Token = "0x40003BE")]
  [FieldOffset(Offset = "0x10")]
  [Space(5f)]
  public bool PrimaryHidden;
  [Token(Token = "0x40003BF")]
  [FieldOffset(Offset = "0x11")]
  public bool PrimaryForceOverride;
  [Token(Token = "0x40003C0")]
  [FieldOffset(Offset = "0x14")]
  public GameObject PrimaryHand;
  [Token(Token = "0x40003C1")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  public string PrimaryRename;
  [Token(Token = "0x40003C2")]
  [FieldOffset(Offset = "0x1C")]
  public List<GameObject> PrimaryHandChangeLists;
  [Token(Token = "0x40003C3")]
  [FieldOffset(Offset = "0x20")]
  [Space(5f)]
  public bool SecondaryHidden;
  [Token(Token = "0x40003C4")]
  [FieldOffset(Offset = "0x21")]
  public bool SecondaryForceOverride;
  [Token(Token = "0x40003C5")]
  [FieldOffset(Offset = "0x24")]
  public GameObject SecondaryHand;
  [Token(Token = "0x40003C6")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  public string SecondaryRename;
  [Token(Token = "0x40003C7")]
  [FieldOffset(Offset = "0x2C")]
  public List<GameObject> SecondaryHandChangeLists;
  [Token(Token = "0x40003C8")]
  [FieldOffset(Offset = "0x30")]
  [Space(5f)]
  [SerializeField]
  public bool TertiaryHidden;
  [Token(Token = "0x40003C9")]
  [FieldOffset(Offset = "0x31")]
  [SerializeField]
  public bool TertiaryForceOverride;
  [Token(Token = "0x40003CA")]
  [FieldOffset(Offset = "0x34")]
  [SerializeField]
  public GameObject TertiaryPlace;
  [Token(Token = "0x40003CB")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  public string TertiaryRename;
  [Token(Token = "0x40003CC")]
  [FieldOffset(Offset = "0x3C")]
  [SerializeField]
  public List<GameObject> TertiaryPlaceChangeLists;
  [Token(Token = "0x40003CD")]
  [FieldOffset(Offset = "0x40")]
  [Space(5f)]
  public List<GameObject> OptionEquipmentLists;

  [Token(Token = "0x6000533")]
  [Address(RVA = "0xC6ED20", Offset = "0xC6DB20", VA = "0x10C6ED20")]
  public EquipmentSet()
  {
  }

  [Token(Token = "0x20000DB")]
  public enum EquipmentPlace
  {
    [Token(Token = "0x40003CF")] PRIMARY,
    [Token(Token = "0x40003D0")] SECONDARY,
    [Token(Token = "0x40003D1")] TERTIARY,
  }

  [Token(Token = "0x20000DC")]
  public enum EquipmentType
  {
    [Token(Token = "0x40003D3")] Melee,
    [Token(Token = "0x40003D4")] Bow,
    [Token(Token = "0x40003D5")] Gun,
  }
}

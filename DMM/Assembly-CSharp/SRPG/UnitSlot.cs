// Decompiled with JetBrains decompiler
// Type: SRPG.UnitSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002CF8")]
  [AddComponentMenu("UI/UnitSlot")]
  public class UnitSlot : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x400DF92")]
    [FieldOffset(Offset = "0xC")]
    public Image Frame;
    [Token(Token = "0x400DF93")]
    [FieldOffset(Offset = "0x10")]
    public Sprite Frame_Leader;
    [Token(Token = "0x400DF94")]
    [FieldOffset(Offset = "0x14")]
    public Sprite Frame_Main;
    [Token(Token = "0x400DF95")]
    [FieldOffset(Offset = "0x18")]
    public Sprite Frame_Hero;
    [Token(Token = "0x400DF96")]
    [FieldOffset(Offset = "0x1C")]
    public Sprite Frame_Support;
    [Token(Token = "0x400DF97")]
    [FieldOffset(Offset = "0x20")]
    public Sprite Frame_Sub;
    [Token(Token = "0x400DF98")]
    [FieldOffset(Offset = "0x24")]
    [Space(10f)]
    public Image Label;
    [Token(Token = "0x400DF99")]
    [FieldOffset(Offset = "0x28")]
    public Sprite Label_Leader;
    [Token(Token = "0x400DF9A")]
    [FieldOffset(Offset = "0x2C")]
    public Sprite Label_Hero;
    [Token(Token = "0x400DF9B")]
    [FieldOffset(Offset = "0x30")]
    public Sprite Label_Support;
    [Token(Token = "0x400DF9C")]
    [FieldOffset(Offset = "0x34")]
    public Sprite Label_Sub;
    [Token(Token = "0x400DF9D")]
    [FieldOffset(Offset = "0x38")]
    [Space(10f)]
    public GameObject Lock;
    [Token(Token = "0x400DF9E")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject Disabled;
    [Token(Token = "0x400DF9F")]
    [FieldOffset(Offset = "0x40")]
    public GameObject Support_Empty;
    [Token(Token = "0x400DFA0")]
    [FieldOffset(Offset = "0x44")]
    [Space(10f)]
    public GameObject OverlayImage;
    [Token(Token = "0x400DFA1")]
    [FieldOffset(Offset = "0x48")]
    [Space(10f)]
    public GameObject RentalIcon;
    [Token(Token = "0x400DFA2")]
    [FieldOffset(Offset = "0x4C")]
    [Space(10f)]
    public GameObject SameUnitIcon;

    [Token(Token = "0x17001B7E")]
    public bool IsOverlayImage
    {
      [Token(Token = "0x600D153"), Address(RVA = "0x2AABD0", Offset = "0x2A99D0", VA = "0x102AABD0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D154"), Address(RVA = "0x610950", Offset = "0x60F750", VA = "0x10610950")] private set
      {
      }
    }

    [Token(Token = "0x600D155")]
    [Address(RVA = "0x9C3920", Offset = "0x9C2720", VA = "0x109C3920")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600D156")]
    [Address(RVA = "0x9C3AC0", Offset = "0x9C28C0", VA = "0x109C3AC0", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600D157")]
    [Address(RVA = "0x9C3980", Offset = "0x9C2780", VA = "0x109C3980")]
    private void SetSlotDisabled()
    {
    }

    [Token(Token = "0x600D158")]
    [Address(RVA = "0x9C3930", Offset = "0x9C2730", VA = "0x109C3930")]
    public void SetSameUnitIcon(bool active)
    {
    }

    [Token(Token = "0x600D159")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitSlot()
    {
    }
  }
}

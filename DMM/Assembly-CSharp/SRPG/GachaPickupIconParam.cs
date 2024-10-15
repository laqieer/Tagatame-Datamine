// Decompiled with JetBrains decompiler
// Type: SRPG.GachaPickupIconParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002414")]
  public class GachaPickupIconParam : ContentSource.Param
  {
    [Token(Token = "0x400A31F")]
    [FieldOffset(Offset = "0x10")]
    private GachaDropIconNode mNode;
    [Token(Token = "0x400A320")]
    [FieldOffset(Offset = "0x14")]
    private Button mButton;

    [Token(Token = "0x170015DD")]
    public GachaDropData drop_data
    {
      [Token(Token = "0x6009D14"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (GachaDropData) null;
      }
      [Token(Token = "0x6009D15"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] set
      {
      }
    }

    [Token(Token = "0x170015DE")]
    public bool interactable
    {
      [Token(Token = "0x6009D16"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009D17"), Address(RVA = "0x2A5AE0", Offset = "0x2A48E0", VA = "0x102A5AE0")] set
      {
      }
    }

    [Token(Token = "0x170015DF")]
    public bool select
    {
      [Token(Token = "0x6009D18"), Address(RVA = "0x5EDE50", Offset = "0x5ECC50", VA = "0x105EDE50")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009D19"), Address(RVA = "0x5EDEC0", Offset = "0x5ECCC0", VA = "0x105EDEC0")] set
      {
      }
    }

    [Token(Token = "0x6009D1A")]
    [Address(RVA = "0x6027B0", Offset = "0x6015B0", VA = "0x106027B0", Slot = "11")]
    public override void OnSetup(ContentNode node)
    {
    }

    [Token(Token = "0x6009D1B")]
    [Address(RVA = "0x602740", Offset = "0x601540", VA = "0x10602740", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x6009D1C")]
    [Address(RVA = "0x602710", Offset = "0x601510", VA = "0x10602710", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x6009D1D")]
    [Address(RVA = "0x602870", Offset = "0x601670", VA = "0x10602870")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6009D1E")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public GachaPickupIconParam()
    {
    }
  }
}

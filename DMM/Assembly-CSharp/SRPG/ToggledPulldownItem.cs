// Decompiled with JetBrains decompiler
// Type: SRPG.ToggledPulldownItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B34")]
  [AddComponentMenu("UI/ToggledPulldownItem")]
  public class ToggledPulldownItem : PulldownItem
  {
    [Token(Token = "0x400D2F3")]
    [FieldOffset(Offset = "0x24")]
    public GameObject imageOn;
    [Token(Token = "0x400D2F4")]
    [FieldOffset(Offset = "0x28")]
    public GameObject imageOff;

    [Token(Token = "0x600C5B9")]
    [Address(RVA = "0x8E44A0", Offset = "0x8E32A0", VA = "0x108E44A0", Slot = "4")]
    public override void OnStatusChanged(bool enabled)
    {
    }

    [Token(Token = "0x600C5BA")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public ToggledPulldownItem()
    {
    }
  }
}

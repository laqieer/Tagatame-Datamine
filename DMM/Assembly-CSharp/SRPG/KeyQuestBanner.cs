// Decompiled with JetBrains decompiler
// Type: SRPG.KeyQuestBanner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002673")]
  [AddComponentMenu("UI/KeyQuestBanner")]
  public class KeyQuestBanner : BaseIcon
  {
    [Token(Token = "0x400B3A6")]
    [FieldOffset(Offset = "0xC")]
    public GameObject IconRoot;
    [Token(Token = "0x400B3A7")]
    [FieldOffset(Offset = "0x10")]
    public RawImage Icon;
    [Token(Token = "0x400B3A8")]
    [FieldOffset(Offset = "0x14")]
    public Image Frame;
    [Token(Token = "0x400B3A9")]
    [FieldOffset(Offset = "0x18")]
    public Text UseNum;
    [Token(Token = "0x400B3AA")]
    [FieldOffset(Offset = "0x1C")]
    public Text Amount;
    [Token(Token = "0x400B3AB")]
    [FieldOffset(Offset = "0x20")]
    public GameObject Locked;
    [Token(Token = "0x400B3AC")]
    [FieldOffset(Offset = "0x24")]
    public QuestTimeLimit QuestTimer;

    [Token(Token = "0x600ABA3")]
    [Address(RVA = "0x6EB7F0", Offset = "0x6EA5F0", VA = "0x106EB7F0", Slot = "12")]
    public override void UpdateValue()
    {
    }

    [Token(Token = "0x600ABA4")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public KeyQuestBanner()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.PulldownItemExpansionPurchase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002861")]
  public class PulldownItemExpansionPurchase : ToggledPulldownItem
  {
    [Token(Token = "0x400C0CF")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject PeriodObj;
    [Token(Token = "0x400C0D0")]
    [FieldOffset(Offset = "0x30")]
    public Text PeriodText;

    [Token(Token = "0x600B670")]
    [Address(RVA = "0x7CCB40", Offset = "0x7CB940", VA = "0x107CCB40")]
    public PulldownItemExpansionPurchase()
    {
    }
  }
}

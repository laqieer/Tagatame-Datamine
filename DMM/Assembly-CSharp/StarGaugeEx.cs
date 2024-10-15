// Decompiled with JetBrains decompiler
// Type: StarGaugeEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002D6")]
[AddComponentMenu("UI/Star GaugeEx")]
public class StarGaugeEx : StarGauge
{
  [Token(Token = "0x4000BC6")]
  [FieldOffset(Offset = "0x20")]
  [Description("明るい星の雛形となるゲームオブジェクト")]
  public GameObject StarExTemplate;
  [Token(Token = "0x4000BC7")]
  [FieldOffset(Offset = "0x24")]
  [Description("暗い星の雛形となるゲームオブジェクト")]
  public GameObject SlotExTemplate;
  [Token(Token = "0x4000BC8")]
  [FieldOffset(Offset = "0x28")]
  private int mValueEx;
  [Token(Token = "0x4000BC9")]
  [FieldOffset(Offset = "0x2C")]
  private int mValueExMax;
  [Token(Token = "0x4000BCA")]
  [FieldOffset(Offset = "0x30")]
  private GameObject[] mStarsEx;

  [Token(Token = "0x170001CB")]
  public int ExValue
  {
    [Token(Token = "0x6000ECF"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
    {
      return new int();
    }
    [Token(Token = "0x6000ED0"), Address(RVA = "0x11DA420", Offset = "0x11D9220", VA = "0x111DA420")] set
    {
    }
  }

  [Token(Token = "0x170001CC")]
  public int ExMax
  {
    [Token(Token = "0x6000ED1"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
    {
      return new int();
    }
    [Token(Token = "0x6000ED2"), Address(RVA = "0x11DA3E0", Offset = "0x11D91E0", VA = "0x111DA3E0")] set
    {
    }
  }

  [Token(Token = "0x6000ED3")]
  [Address(RVA = "0x11DA050", Offset = "0x11D8E50", VA = "0x111DA050")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x6000ED4")]
  [Address(RVA = "0x11DA070", Offset = "0x11D8E70", VA = "0x111DA070")]
  private void SetExValueState()
  {
  }

  [Token(Token = "0x6000ED5")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public StarGaugeEx()
  {
  }
}

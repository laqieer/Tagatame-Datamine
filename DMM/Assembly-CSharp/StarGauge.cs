// Decompiled with JetBrains decompiler
// Type: StarGauge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002D5")]
[AddComponentMenu("UI/Star Gauge")]
public class StarGauge : MonoBehaviour
{
  [Token(Token = "0x4000BC1")]
  [FieldOffset(Offset = "0xC")]
  [Description("明るい星の雛形となるゲームオブジェクト")]
  public GameObject StarTemplate;
  [Token(Token = "0x4000BC2")]
  [FieldOffset(Offset = "0x10")]
  [Description("暗い星の雛形となるゲームオブジェクト")]
  public GameObject SlotTemplate;
  [Token(Token = "0x4000BC3")]
  [FieldOffset(Offset = "0x14")]
  private int mValue;
  [Token(Token = "0x4000BC4")]
  [FieldOffset(Offset = "0x18")]
  private int mValueMax;
  [Token(Token = "0x4000BC5")]
  [FieldOffset(Offset = "0x1C")]
  private GameObject[] mStars;

  [Token(Token = "0x170001C9")]
  public int Value
  {
    [Token(Token = "0x6000EC8"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
    {
      return new int();
    }
    [Token(Token = "0x6000EC9"), Address(RVA = "0x11DA820", Offset = "0x11D9620", VA = "0x111DA820")] set
    {
    }
  }

  [Token(Token = "0x170001CA")]
  public int Max
  {
    [Token(Token = "0x6000ECA"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
    {
      return new int();
    }
    [Token(Token = "0x6000ECB"), Address(RVA = "0x11DA7E0", Offset = "0x11D95E0", VA = "0x111DA7E0")] set
    {
    }
  }

  [Token(Token = "0x6000ECC")]
  [Address(RVA = "0x11DA460", Offset = "0x11D9260", VA = "0x111DA460")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x6000ECD")]
  [Address(RVA = "0x11DA470", Offset = "0x11D9270", VA = "0x111DA470")]
  public void SetValueState()
  {
  }

  [Token(Token = "0x6000ECE")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public StarGauge()
  {
  }
}

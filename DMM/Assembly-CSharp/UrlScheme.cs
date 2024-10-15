// Decompiled with JetBrains decompiler
// Type: UrlScheme
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000315")]
[AddComponentMenu("/UrlScheme")]
public class UrlScheme : MonoSingleton<UrlScheme>
{
  [Token(Token = "0x170001DB")]
  public string ParamString
  {
    [Token(Token = "0x600100A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
    {
      return (string) null;
    }
    [Token(Token = "0x600100B"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
    {
    }
  }

  [Token(Token = "0x170001DC")]
  public bool IsLaunch
  {
    [Token(Token = "0x600100C"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
    {
      return new bool();
    }
    [Token(Token = "0x600100D"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] set
    {
    }
  }

  [Token(Token = "0x600100E")]
  [Address(RVA = "0x12AF720", Offset = "0x12AE520", VA = "0x112AF720", Slot = "4")]
  protected override void Initialize()
  {
  }

  [Token(Token = "0x600100F")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
  protected override void Release()
  {
  }

  [Token(Token = "0x6001010")]
  [Address(RVA = "0x12AF880", Offset = "0x12AE680", VA = "0x112AF880")]
  private void OnApplicationPause(bool pause)
  {
  }

  [Token(Token = "0x6001011")]
  [Address(RVA = "0x12AF8C0", Offset = "0x12AE6C0", VA = "0x112AF8C0")]
  public UrlScheme()
  {
  }
}

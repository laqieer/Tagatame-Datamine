// Decompiled with JetBrains decompiler
// Type: SRPG.HomeUnitVoiceParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B9E")]
  [MessagePackObject(true)]
  public class HomeUnitVoiceParam
  {
    [Token(Token = "0x4006951")]
    [FieldOffset(Offset = "0x8")]
    private string mUnitIname;
    [Token(Token = "0x4006952")]
    [FieldOffset(Offset = "0xC")]
    private string[] mVoices;

    [Token(Token = "0x17000DD5")]
    public string UnitIname
    {
      [Token(Token = "0x6007217"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DD6")]
    public string[] Voices
    {
      [Token(Token = "0x6007218"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x6007219")]
    [Address(RVA = "0x375F60", Offset = "0x374D60", VA = "0x10375F60")]
    public bool Deserialize(JSON_HomeUnitVoiceParam json) => new bool();

    [Token(Token = "0x600721A")]
    [Address(RVA = "0x375CB0", Offset = "0x374AB0", VA = "0x10375CB0")]
    public static bool Deserialize(
      ref List<HomeUnitVoiceParam> paramList,
      JSON_HomeUnitVoiceParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x600721B")]
    [Address(RVA = "0x376070", Offset = "0x374E70", VA = "0x10376070")]
    public HomeUnitVoiceParam()
    {
    }
  }
}

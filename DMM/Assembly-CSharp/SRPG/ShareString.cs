// Decompiled with JetBrains decompiler
// Type: SRPG.ShareString
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D18")]
  public class ShareString
  {
    [Token(Token = "0x400721E")]
    [FieldOffset(Offset = "0x8")]
    private List<List<string>> m_string_types;

    [Token(Token = "0x600776B")]
    [Address(RVA = "0x39F3F0", Offset = "0x39E1F0", VA = "0x1039F3F0")]
    public ShareString()
    {
    }

    [Token(Token = "0x600776C")]
    [Address(RVA = "0x39F2D0", Offset = "0x39E0D0", VA = "0x1039F2D0")]
    public short Set(ShareString.Type type, string val) => new short();

    [Token(Token = "0x600776D")]
    [Address(RVA = "0x39F210", Offset = "0x39E010", VA = "0x1039F210")]
    public string Get(ShareString.Type type, short index) => (string) null;

    [Token(Token = "0x600776E")]
    [Address(RVA = "0x39F1B0", Offset = "0x39DFB0", VA = "0x1039F1B0")]
    private List<string> ChoiceDicitionary(ShareString.Type type) => (List<string>) null;

    [Token(Token = "0x2001D19")]
    public enum Type : byte
    {
      [Token(Token = "0x4007220")] QuestParam_cond,
      [Token(Token = "0x4007221")] QuestParam_world,
      [Token(Token = "0x4007222")] QuestParam_area,
      [Token(Token = "0x4007223")] QuestParam_units,
      [Token(Token = "0x4007224")] QuestParam_ticket,
      [Token(Token = "0x4007225")] ChapterParam_world,
      [Token(Token = "0x4007226")] ChapterParam_section,
      [Token(Token = "0x4007227")] MapParam_battleSceneName,
      [Token(Token = "0x4007228")] MapParam_bgmName,
      [Token(Token = "0x4007229")] MAX_TYPE,
    }
  }
}

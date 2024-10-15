// Decompiled with JetBrains decompiler
// Type: SRPG.SectionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D15")]
  public class SectionParam
  {
    [Token(Token = "0x4007205")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007206")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4007207")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x4007208")]
    [FieldOffset(Offset = "0x18")]
    public long start;
    [Token(Token = "0x4007209")]
    [FieldOffset(Offset = "0x20")]
    public long end;
    [Token(Token = "0x400720A")]
    [FieldOffset(Offset = "0x28")]
    public bool hidden;
    [Token(Token = "0x400720B")]
    [FieldOffset(Offset = "0x2C")]
    public string home;
    [Token(Token = "0x400720C")]
    [FieldOffset(Offset = "0x30")]
    public string unit;
    [Token(Token = "0x400720D")]
    [FieldOffset(Offset = "0x34")]
    public string prefabPath;
    [Token(Token = "0x400720E")]
    [FieldOffset(Offset = "0x38")]
    public string shop;
    [Token(Token = "0x400720F")]
    [FieldOffset(Offset = "0x3C")]
    public string inn;
    [Token(Token = "0x4007210")]
    [FieldOffset(Offset = "0x40")]
    public string bar;
    [Token(Token = "0x4007211")]
    [FieldOffset(Offset = "0x44")]
    public string bgm;
    [Token(Token = "0x4007212")]
    [FieldOffset(Offset = "0x48")]
    public int storyPart;
    [Token(Token = "0x4007213")]
    [FieldOffset(Offset = "0x4C")]
    public string releaseKeyQuest;
    [Token(Token = "0x4007214")]
    [FieldOffset(Offset = "0x50")]
    public string message_sys_id;
    [Token(Token = "0x4007215")]
    public const string SEISEKI_SECTION_INAME = "WD_SEISEKI";
    [Token(Token = "0x4007216")]
    public const string BABEL_SECTION_INAME = "WD_BABEL";
    [Token(Token = "0x4007217")]
    public const string DAILY_SECTION_INAME = "WD_DAILY";
    [Token(Token = "0x4007218")]
    public const string GENESIS_SECTION_INAME = "WD_GENESIS";
    [Token(Token = "0x4007219")]
    public const string ADVANCE_SECTION_INAME = "WD_ADVANCE";
    [Token(Token = "0x400721A")]
    public const string RENTAL_SECTION_INAME = "WD_RENTAL";
    [Token(Token = "0x400721B")]
    public const string DRAGONGOD_SECTION_INAME = "WD_DRAGONGOD";
    [Token(Token = "0x400721C")]
    public const string POINTEVENT_SECTION_INAME = "WD_POINTEVENT";

    [Token(Token = "0x6007764")]
    [Address(RVA = "0x39EB40", Offset = "0x39D940", VA = "0x1039EB40")]
    public void Deserialize(JSON_SectionParam json)
    {
    }

    [Token(Token = "0x6007765")]
    [Address(RVA = "0x39EC70", Offset = "0x39DA70", VA = "0x1039EC70")]
    public bool IsDateUnlock() => new bool();

    [Token(Token = "0x6007766")]
    [Address(RVA = "0x39ECF0", Offset = "0x39DAF0", VA = "0x1039ECF0")]
    public static bool IsPointQuestSection(string section) => new bool();

    [Token(Token = "0x6007767")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SectionParam()
    {
    }
  }
}

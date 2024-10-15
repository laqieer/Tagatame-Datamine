// Decompiled with JetBrains decompiler
// Type: SRPG.JukeBoxParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AFB")]
  [MessagePackObject(true)]
  public class JukeBoxParam
  {
    [Token(Token = "0x40066B9")]
    [IgnoreMember]
    private const string JUKUBOX_TITLE_SUFFIX = "_TITLE";
    [Token(Token = "0x40066BA")]
    [IgnoreMember]
    private const string JUKUBOX_TITLE_EN_SUFFIX = "_TITLE_EN";
    [Token(Token = "0x40066BB")]
    [IgnoreMember]
    private const string JUKUBOX_LYRICIST_SUFFIX = "_LYRICIST";
    [Token(Token = "0x40066BC")]
    [IgnoreMember]
    private const string JUKUBOX_COMPOSER_SUFFIX = "_COMPOSER";
    [Token(Token = "0x40066BD")]
    [IgnoreMember]
    private const string JUKUBOX_SITUATION_SUFFIX = "_SITUATION";
    [Token(Token = "0x40066BE")]
    [IgnoreMember]
    private const string JUKUBOX_TEXT_TABLE = "external_jukebox";
    [Token(Token = "0x40066BF")]
    [FieldOffset(Offset = "0x8")]
    private string iname;
    [Token(Token = "0x40066C0")]
    [FieldOffset(Offset = "0xC")]
    private string sheet;
    [Token(Token = "0x40066C1")]
    [FieldOffset(Offset = "0x10")]
    private string cue;
    [Token(Token = "0x40066C2")]
    [FieldOffset(Offset = "0x14")]
    private string section;
    [Token(Token = "0x40066C3")]
    [FieldOffset(Offset = "0x18")]
    private bool default_unlock;
    [Token(Token = "0x40066C4")]
    [FieldOffset(Offset = "0x1C")]
    private int external_link;
    [Token(Token = "0x40066C5")]
    [FieldOffset(Offset = "0x20")]
    private int rate;
    [Token(Token = "0x40066C6")]
    [FieldOffset(Offset = "0x24")]
    private JukeBoxParam.eUnlockType unlock_type;
    [Token(Token = "0x40066C7")]
    [FieldOffset(Offset = "0x28")]
    private string[] quests;
    [Token(Token = "0x40066C8")]
    [FieldOffset(Offset = "0x2C")]
    private string cond_quest;

    [Token(Token = "0x17000CD7")]
    public string Iname
    {
      [Token(Token = "0x6006F53"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CD8")]
    public string Sheet
    {
      [Token(Token = "0x6006F54"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CD9")]
    public string Cue
    {
      [Token(Token = "0x6006F55"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CDA")]
    public string SectionId
    {
      [Token(Token = "0x6006F56"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CDB")]
    public string Title
    {
      [Token(Token = "0x6006F57"), Address(RVA = "0x36C190", Offset = "0x36AF90", VA = "0x1036C190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CDC")]
    public string TitleEn
    {
      [Token(Token = "0x6006F58"), Address(RVA = "0x36C140", Offset = "0x36AF40", VA = "0x1036C140")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CDD")]
    public string Lyricist
    {
      [Token(Token = "0x6006F59"), Address(RVA = "0x36C0A0", Offset = "0x36AEA0", VA = "0x1036C0A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CDE")]
    public string Composer
    {
      [Token(Token = "0x6006F5A"), Address(RVA = "0x36BFA0", Offset = "0x36ADA0", VA = "0x1036BFA0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CDF")]
    public string Situation
    {
      [Token(Token = "0x6006F5B"), Address(RVA = "0x36C0F0", Offset = "0x36AEF0", VA = "0x1036C0F0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CE0")]
    public bool DefaultUnlock
    {
      [Token(Token = "0x6006F5C"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CE1")]
    public int ExternalLink
    {
      [Token(Token = "0x6006F5D"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CE2")]
    public int Rate
    {
      [Token(Token = "0x6006F5E"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CE3")]
    public JukeBoxParam.eUnlockType UnlockType
    {
      [Token(Token = "0x6006F5F"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new JukeBoxParam.eUnlockType();
      }
    }

    [Token(Token = "0x17000CE4")]
    public List<string> CondList
    {
      [Token(Token = "0x6006F60"), Address(RVA = "0x36C000", Offset = "0x36AE00", VA = "0x1036C000")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17000CE5")]
    public string CondQuest
    {
      [Token(Token = "0x6006F61"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006F62")]
    [Address(RVA = "0x36BC60", Offset = "0x36AA60", VA = "0x1036BC60")]
    public bool Deserialize(JSON_JukeBoxParam json) => new bool();

    [Token(Token = "0x6006F63")]
    [Address(RVA = "0x36BF00", Offset = "0x36AD00", VA = "0x1036BF00")]
    public static string GetText(string table, string key) => (string) null;

    [Token(Token = "0x6006F64")]
    [Address(RVA = "0x36BDD0", Offset = "0x36ABD0", VA = "0x1036BDD0")]
    public static void Deserialize(ref List<JukeBoxParam> ref_params, JSON_JukeBoxParam[] json)
    {
    }

    [Token(Token = "0x6006F65")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JukeBoxParam()
    {
    }

    [Token(Token = "0x2001AFC")]
    public enum eUnlockType
    {
      [Token(Token = "0x40066CA")] QUEST,
      [Token(Token = "0x40066CB")] AREA,
    }
  }
}

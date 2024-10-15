// Decompiled with JetBrains decompiler
// Type: SRPG.ExternalVideoLinkParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AE2")]
  public class ExternalVideoLinkParam
  {
    [Token(Token = "0x40063B7")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40063B8")]
    [FieldOffset(Offset = "0xC")]
    private ExternalVideoLinkParam.ePlaceType mPlaceType;
    [Token(Token = "0x40063B9")]
    [FieldOffset(Offset = "0x10")]
    private string mVideoPath;
    [Token(Token = "0x40063BA")]
    [FieldOffset(Offset = "0x14")]
    private string mTextPath;
    [Token(Token = "0x40063BB")]
    [FieldOffset(Offset = "0x18")]
    private int mHideLevel;
    [Token(Token = "0x40063BC")]
    [FieldOffset(Offset = "0x1C")]
    private string mUnitIname;
    [Token(Token = "0x40063BD")]
    [FieldOffset(Offset = "0x20")]
    private string[] mQuestInames;

    [Token(Token = "0x17000C8E")]
    public string Iname
    {
      [Token(Token = "0x6006EB7"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C8F")]
    public ExternalVideoLinkParam.ePlaceType PlaceType
    {
      [Token(Token = "0x6006EB8"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new ExternalVideoLinkParam.ePlaceType();
      }
    }

    [Token(Token = "0x17000C90")]
    public string VideoPath
    {
      [Token(Token = "0x6006EB9"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C91")]
    public string TextPath
    {
      [Token(Token = "0x6006EBA"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C92")]
    public int HideLevel
    {
      [Token(Token = "0x6006EBB"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C93")]
    public string UnitIname
    {
      [Token(Token = "0x6006EBC"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C94")]
    public string[] QuestInames
    {
      [Token(Token = "0x6006EBD"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x6006EBE")]
    [Address(RVA = "0x362730", Offset = "0x361530", VA = "0x10362730")]
    public bool Deserialize(JSON_ExternalVideoLinkParam json) => new bool();

    [Token(Token = "0x6006EBF")]
    [Address(RVA = "0x362880", Offset = "0x361680", VA = "0x10362880")]
    public static void Deserialize(
      ref List<ExternalVideoLinkParam> ref_params,
      JSON_ExternalVideoLinkParam[] json)
    {
    }

    [Token(Token = "0x6006EC0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ExternalVideoLinkParam()
    {
    }

    [Token(Token = "0x2001AE3")]
    public enum ePlaceType
    {
      [Token(Token = "0x40063BF")] None,
      [Token(Token = "0x40063C0")] ConceptCard,
      [Token(Token = "0x40063C1")] Artifact,
      [Token(Token = "0x40063C2")] Job,
      [Token(Token = "0x40063C3")] Ability,
      [Token(Token = "0x40063C4")] Evolution,
      [Token(Token = "0x40063C5")] Rune,
      [Token(Token = "0x40063C6")] Unit,
      [Token(Token = "0x40063C7")] Quest,
    }
  }
}

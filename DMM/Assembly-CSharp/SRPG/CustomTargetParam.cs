// Decompiled with JetBrains decompiler
// Type: SRPG.CustomTargetParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DEE")]
  public class CustomTargetParam
  {
    [Token(Token = "0x40078A9")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40078AA")]
    [FieldOffset(Offset = "0xC")]
    public string[] units;
    [Token(Token = "0x40078AB")]
    [FieldOffset(Offset = "0x10")]
    public string[] jobs;
    [Token(Token = "0x40078AC")]
    [FieldOffset(Offset = "0x14")]
    public string[] unit_groups;
    [Token(Token = "0x40078AD")]
    [FieldOffset(Offset = "0x18")]
    public string[] job_groups;
    [Token(Token = "0x40078AE")]
    [FieldOffset(Offset = "0x1C")]
    public string[] concept_card_groups;
    [Token(Token = "0x40078AF")]
    [FieldOffset(Offset = "0x20")]
    public string first_job;
    [Token(Token = "0x40078B0")]
    [FieldOffset(Offset = "0x24")]
    public string second_job;
    [Token(Token = "0x40078B1")]
    [FieldOffset(Offset = "0x28")]
    public string third_job;
    [Token(Token = "0x40078B2")]
    [FieldOffset(Offset = "0x2C")]
    public ESex sex;
    [Token(Token = "0x40078B3")]
    [FieldOffset(Offset = "0x30")]
    public int birth_id;
    [Token(Token = "0x40078B4")]
    [FieldOffset(Offset = "0x34")]
    public int element;

    [Token(Token = "0x6007A6C")]
    [Address(RVA = "0x3BDBA0", Offset = "0x3BC9A0", VA = "0x103BDBA0")]
    public bool Deserialize(JSON_CustomTargetParam json) => new bool();

    [Token(Token = "0x6007A6D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CustomTargetParam()
    {
    }
  }
}

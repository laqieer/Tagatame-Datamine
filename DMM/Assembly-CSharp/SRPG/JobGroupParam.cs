// Decompiled with JetBrains decompiler
// Type: SRPG.JobGroupParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E06")]
  public class JobGroupParam
  {
    [Token(Token = "0x400799E")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400799F")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x40079A0")]
    [FieldOffset(Offset = "0x10")]
    public string[] jobs;

    [Token(Token = "0x6007B51")]
    [Address(RVA = "0x3DFDE0", Offset = "0x3DEBE0", VA = "0x103DFDE0")]
    public bool Deserialize(JSON_JobGroupParam json) => new bool();

    [Token(Token = "0x6007B52")]
    [Address(RVA = "0x3DFE30", Offset = "0x3DEC30", VA = "0x103DFE30")]
    public bool IsInGroup(string job_iname) => new bool();

    [Token(Token = "0x6007B53")]
    [Address(RVA = "0x3DFEF0", Offset = "0x3DECF0", VA = "0x103DFEF0")]
    public static bool IsInGroup(JobGroupParam[] group_param, UnitParam unit_param) => new bool();

    [Token(Token = "0x6007B54")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JobGroupParam()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.JobSetParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E12")]
  public class JobSetParam
  {
    [Token(Token = "0x4007A30")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007A31")]
    [FieldOffset(Offset = "0xC")]
    public string job;
    [Token(Token = "0x4007A32")]
    [FieldOffset(Offset = "0x10")]
    public int lock_rarity;
    [Token(Token = "0x4007A33")]
    [FieldOffset(Offset = "0x14")]
    public int lock_awakelv;
    [Token(Token = "0x4007A34")]
    [FieldOffset(Offset = "0x18")]
    public JobSetParam.JobLock[] lock_jobs;
    [Token(Token = "0x4007A35")]
    [FieldOffset(Offset = "0x1C")]
    public string jobchange;
    [Token(Token = "0x4007A36")]
    [FieldOffset(Offset = "0x20")]
    public string target_unit;
    [Token(Token = "0x4007A37")]
    [FieldOffset(Offset = "0x24")]
    private int joblv_opened;

    [Token(Token = "0x170010F6")]
    public int JobLvOpened
    {
      [Token(Token = "0x6007B76"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007B77")]
    [Address(RVA = "0x3E1D80", Offset = "0x3E0B80", VA = "0x103E1D80")]
    public bool Deserialize(JSON_JobSetParam json) => new bool();

    [Token(Token = "0x6007B78")]
    [Address(RVA = "0x3E1CD0", Offset = "0x3E0AD0", VA = "0x103E1CD0")]
    public bool ContainsJob(string iname) => new bool();

    [Token(Token = "0x6007B79")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JobSetParam()
    {
    }

    [Token(Token = "0x2001E13")]
    public class JobLock
    {
      [Token(Token = "0x4007A38")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x4007A39")]
      [FieldOffset(Offset = "0xC")]
      public int lv;

      [Token(Token = "0x6007B7A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JobLock()
      {
      }
    }
  }
}

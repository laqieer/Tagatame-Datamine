// Decompiled with JetBrains decompiler
// Type: SRPG.BattleLogServer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Text;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BCF")]
  public class BattleLogServer
  {
    [Token(Token = "0x4001DF0")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int MAX_REGISTER_BATTLE_LOG;
    [Token(Token = "0x4001DF1")]
    [FieldOffset(Offset = "0x4")]
    private static readonly int BATTLE_LOG_REPORT_SIZE;
    [Token(Token = "0x4001DF2")]
    [FieldOffset(Offset = "0x8")]
    private BattleLog[] mLogs;
    [Token(Token = "0x4001DF3")]
    [FieldOffset(Offset = "0xC")]
    private int mLogNum;
    [Token(Token = "0x4001DF4")]
    [FieldOffset(Offset = "0x10")]
    private int mLogTop;
    [Token(Token = "0x4001DF5")]
    [FieldOffset(Offset = "0x14")]
    private StringBuilder mReport;

    [Token(Token = "0x170002C9")]
    public BattleLog this[int offset]
    {
      [Token(Token = "0x6002F8D"), Address(RVA = "0xFD8330", Offset = "0xFD7130", VA = "0x10FD8330")] get
      {
        return (BattleLog) null;
      }
    }

    [Token(Token = "0x170002CA")]
    public int Num
    {
      [Token(Token = "0x6002F8E"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170002CB")]
    public int Top
    {
      [Token(Token = "0x6002F8F"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170002CC")]
    public BattleLog Peek
    {
      [Token(Token = "0x6002F90"), Address(RVA = "0xFD83A0", Offset = "0xFD71A0", VA = "0x10FD83A0")] get
      {
        return (BattleLog) null;
      }
    }

    [Token(Token = "0x170002CD")]
    public BattleLog Last
    {
      [Token(Token = "0x6002F91"), Address(RVA = "0xFD8360", Offset = "0xFD7160", VA = "0x10FD8360")] get
      {
        return (BattleLog) null;
      }
    }

    [Token(Token = "0x170002CE")]
    public StringBuilder Report
    {
      [Token(Token = "0x6002F92"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (StringBuilder) null;
      }
    }

    [Token(Token = "0x6002F93")]
    [Address(RVA = "0xFD8210", Offset = "0xFD7010", VA = "0x10FD8210")]
    public BattleLogServer()
    {
    }

    [Token(Token = "0x6002F94")]
    [Address(RVA = "0xFD7C90", Offset = "0xFD6A90", VA = "0x10FD7C90")]
    public void Release()
    {
    }

    [Token(Token = "0x6002F95")]
    [Address(RVA = "0xFD8050", Offset = "0xFD6E50", VA = "0x10FD8050")]
    public void Reset()
    {
    }

    [Token(Token = "0x6002F96")]
    public LogType Log<LogType>() where LogType : BattleLog, new() => (LogType) null;

    [Token(Token = "0x6002F97")]
    [Address(RVA = "0xFD7FC0", Offset = "0xFD6DC0", VA = "0x10FD7FC0")]
    public void RemoveLog()
    {
    }

    [Token(Token = "0x6002F98")]
    [Address(RVA = "0xFD7D20", Offset = "0xFD6B20", VA = "0x10FD7D20")]
    public void RemoveLogLast()
    {
    }

    [Token(Token = "0x6002F99")]
    [Address(RVA = "0xFD7D80", Offset = "0xFD6B80", VA = "0x10FD7D80")]
    public void RemoveLogOffs(int offs)
    {
    }

    [Token(Token = "0x6002F9A")]
    [Address(RVA = "0xFD80C0", Offset = "0xFD6EC0", VA = "0x10FD80C0")]
    public void SwapLogDataLast()
    {
    }

    [Token(Token = "0x6002F9B")]
    [Address(RVA = "0xFD81D0", Offset = "0xFD6FD0", VA = "0x10FD81D0")]
    static BattleLogServer()
    {
    }
  }
}

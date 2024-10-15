// Decompiled with JetBrains decompiler
// Type: SRPG.GuildEntryConditions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F8D")]
  public class GuildEntryConditions
  {
    [Token(Token = "0x40036B7")]
    [FieldOffset(Offset = "0x8")]
    private int mLowerLevel;
    [Token(Token = "0x40036B8")]
    [FieldOffset(Offset = "0xC")]
    private bool mIsAutoApproval;
    [Token(Token = "0x40036B9")]
    [FieldOffset(Offset = "0x10")]
    private string mComment;
    [Token(Token = "0x40036BA")]
    [FieldOffset(Offset = "0x14")]
    private int mPolicy;

    [Token(Token = "0x17000584")]
    public int LowerLevel
    {
      [Token(Token = "0x6004096"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6004097"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] set
      {
      }
    }

    [Token(Token = "0x17000585")]
    public bool IsAutoApproval
    {
      [Token(Token = "0x6004098"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004099"), Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")] set
      {
      }
    }

    [Token(Token = "0x17000586")]
    public string Comment
    {
      [Token(Token = "0x600409A"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600409B"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
      {
      }
    }

    [Token(Token = "0x17000587")]
    public int Policy
    {
      [Token(Token = "0x600409C"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
      [Token(Token = "0x600409D"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] set
      {
      }
    }

    [Token(Token = "0x600409E")]
    [Address(RVA = "0x1191E60", Offset = "0x1190C60", VA = "0x11191E60")]
    public GuildEntryConditions()
    {
    }

    [Token(Token = "0x600409F")]
    [Address(RVA = "0x1191DE0", Offset = "0x1190BE0", VA = "0x11191DE0")]
    public bool Deserialize(JSON_GuildEntryCondition json) => new bool();
  }
}

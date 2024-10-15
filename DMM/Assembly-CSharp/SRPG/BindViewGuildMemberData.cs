// Decompiled with JetBrains decompiler
// Type: SRPG.BindViewGuildMemberData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002520")]
  public class BindViewGuildMemberData
  {
    [Token(Token = "0x400A9C0")]
    [FieldOffset(Offset = "0x8")]
    private GuildManager.GuildAttendStatus mAttendStatus;

    [Token(Token = "0x170016C4")]
    public GuildManager.GuildAttendStatus AttendStatus
    {
      [Token(Token = "0x600A339"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new GuildManager.GuildAttendStatus();
      }
    }

    [Token(Token = "0x600A33A")]
    [Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")]
    public void SetAttendStatus(GuildManager.GuildAttendStatus status)
    {
    }

    [Token(Token = "0x600A33B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BindViewGuildMemberData()
    {
    }
  }
}

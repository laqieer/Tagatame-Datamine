// Decompiled with JetBrains decompiler
// Type: SRPG.HomeApi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200308C")]
  public class HomeApi : WebAPI
  {
    [Token(Token = "0x600DD0C")]
    [Address(RVA = "0xA7FFA0", Offset = "0xA7EDA0", VA = "0x10A7FFA0")]
    public HomeApi(HomeApi.HomeApiParams param, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x200308D")]
    public class HomeApiParams
    {
      [Token(Token = "0x400EC0F")]
      [FieldOffset(Offset = "0x8")]
      public bool isMultiPush;
      [Token(Token = "0x400EC10")]
      [FieldOffset(Offset = "0x9")]
      public bool isGuildInvite;
      [Token(Token = "0x400EC11")]
      [FieldOffset(Offset = "0xA")]
      public bool isReqCoinBonus;
      [Token(Token = "0x400EC12")]
      [FieldOffset(Offset = "0xB")]
      public bool isAutoRepeatQuest;
      [Token(Token = "0x400EC13")]
      [FieldOffset(Offset = "0xC")]
      public bool isReqPartyOverWrite;
      [Token(Token = "0x400EC14")]
      [FieldOffset(Offset = "0xD")]
      public bool isGuildRoleReward;
      [Token(Token = "0x400EC15")]
      [FieldOffset(Offset = "0xE")]
      public bool isLogin;
      [Token(Token = "0x400EC16")]
      [FieldOffset(Offset = "0xF")]
      public bool isAppearingWorldRaid;
      [Token(Token = "0x400EC17")]
      [FieldOffset(Offset = "0x10")]
      public bool isPublicInfo;

      [Token(Token = "0x600DD0D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public HomeApiParams()
      {
      }
    }
  }
}

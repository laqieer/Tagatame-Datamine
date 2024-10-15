// Decompiled with JetBrains decompiler
// Type: SRPG.UpdateTrophyInterval
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018CF")]
  public class UpdateTrophyInterval
  {
    [Token(Token = "0x4005978")]
    [FieldOffset(Offset = "0x8")]
    private float updat_torphy_interval;
    [Token(Token = "0x4005979")]
    private const float NOW_TROPHY_INTERVAL_TIME = 0.0f;
    [Token(Token = "0x400597A")]
    private const float UPDATE_TROPHY_INTERVAL_TIME = 5f;
    [Token(Token = "0x400597B")]
    private const float SYNC_TROPHY_INTERVAL_TIME = 0.1f;

    [Token(Token = "0x6006383")]
    [Address(RVA = "0x319710", Offset = "0x318510", VA = "0x10319710")]
    public void SetSyncNow()
    {
    }

    [Token(Token = "0x6006384")]
    [Address(RVA = "0x3196F0", Offset = "0x3184F0", VA = "0x103196F0")]
    public void SetSyncInterval()
    {
    }

    [Token(Token = "0x6006385")]
    [Address(RVA = "0x319720", Offset = "0x318520", VA = "0x10319720")]
    public void SetUpdateInterval()
    {
    }

    [Token(Token = "0x6006386")]
    [Address(RVA = "0x3196B0", Offset = "0x3184B0", VA = "0x103196B0")]
    public bool PlayCheckUpdate() => new bool();

    [Token(Token = "0x6006387")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UpdateTrophyInterval()
    {
    }
  }
}

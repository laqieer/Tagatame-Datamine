// Decompiled with JetBrains decompiler
// Type: SRPG.VersusStatusInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002755")]
  [AddComponentMenu("UI/Multi/Versus/VersusStatusInfo")]
  public class VersusStatusInfo : MonoBehaviour
  {
    [Token(Token = "0x400B9A7")]
    [FieldOffset(Offset = "0xC")]
    private readonly string COIN_NAME;
    [Token(Token = "0x400B9A8")]
    [FieldOffset(Offset = "0x10")]
    public Text FreeCnt;
    [Token(Token = "0x400B9A9")]
    [FieldOffset(Offset = "0x14")]
    public Text TowerCnt;
    [Token(Token = "0x400B9AA")]
    [FieldOffset(Offset = "0x18")]
    public Text FriendCnt;
    [Token(Token = "0x400B9AB")]
    [FieldOffset(Offset = "0x1C")]
    public Text VSCoinCnt;
    [Token(Token = "0x400B9AC")]
    [FieldOffset(Offset = "0x20")]
    public Text FreeRate;
    [Token(Token = "0x400B9AD")]
    [FieldOffset(Offset = "0x24")]
    public Text TowerRate;
    [Token(Token = "0x400B9AE")]
    [FieldOffset(Offset = "0x28")]
    public Text FriendRate;

    [Token(Token = "0x600B07D")]
    [Address(RVA = "0x751A00", Offset = "0x750800", VA = "0x10751A00")]
    private void Start()
    {
    }

    [Token(Token = "0x600B07E")]
    [Address(RVA = "0x751650", Offset = "0x750450", VA = "0x10751650")]
    private void RefreshData()
    {
    }

    [Token(Token = "0x600B07F")]
    [Address(RVA = "0x7515C0", Offset = "0x7503C0", VA = "0x107515C0")]
    private string GenerateWinRateString(int wincnt, int totalcnt) => (string) null;

    [Token(Token = "0x600B080")]
    [Address(RVA = "0x751A10", Offset = "0x750810", VA = "0x10751A10")]
    public VersusStatusInfo()
    {
    }
  }
}

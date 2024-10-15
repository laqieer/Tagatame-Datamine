// Decompiled with JetBrains decompiler
// Type: SRPG.TowerRewardIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B60")]
  [AddComponentMenu("UI/TowerRewardIcon")]
  public class TowerRewardIcon : MonoBehaviour
  {
    [Token(Token = "0x400D450")]
    [FieldOffset(Offset = "0xC")]
    public GameParameter ItemIcon;
    [Token(Token = "0x400D451")]
    [FieldOffset(Offset = "0x10")]
    public RawImage_Transparent BaseImage;
    [Token(Token = "0x400D452")]
    [FieldOffset(Offset = "0x14")]
    public BitmapText NumText;
    [Token(Token = "0x400D453")]
    [FieldOffset(Offset = "0x18")]
    public Texture GoldImage;
    [Token(Token = "0x400D454")]
    [FieldOffset(Offset = "0x1C")]
    public Texture CoinImage;
    [Token(Token = "0x400D455")]
    [FieldOffset(Offset = "0x20")]
    public Texture ArenaCoinImage;
    [Token(Token = "0x400D456")]
    [FieldOffset(Offset = "0x24")]
    public Texture MultiCoinImage;
    [Token(Token = "0x400D457")]
    [FieldOffset(Offset = "0x28")]
    public Texture KakeraCoinImage;

    [Token(Token = "0x600C6B3")]
    [Address(RVA = "0x8F2DF0", Offset = "0x8F1BF0", VA = "0x108F2DF0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C6B4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TowerRewardIcon()
    {
    }
  }
}

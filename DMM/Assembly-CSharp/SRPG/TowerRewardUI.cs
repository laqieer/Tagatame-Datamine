// Decompiled with JetBrains decompiler
// Type: SRPG.TowerRewardUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B61")]
  [AddComponentMenu("UI/TowerRewardUI")]
  public class TowerRewardUI : MonoBehaviour
  {
    [Token(Token = "0x400D458")]
    [FieldOffset(Offset = "0xC")]
    public GameParameter ItemIcon;
    [Token(Token = "0x400D459")]
    [FieldOffset(Offset = "0x10")]
    public RawImage_Transparent BaseImage;
    [Token(Token = "0x400D45A")]
    [FieldOffset(Offset = "0x14")]
    public BitmapText NumText;
    [Token(Token = "0x400D45B")]
    [FieldOffset(Offset = "0x18")]
    public Texture GoldImage;
    [Token(Token = "0x400D45C")]
    [FieldOffset(Offset = "0x1C")]
    public Texture CoinImage;
    [Token(Token = "0x400D45D")]
    [FieldOffset(Offset = "0x20")]
    public Texture ArenaCoinImage;
    [Token(Token = "0x400D45E")]
    [FieldOffset(Offset = "0x24")]
    public Texture MultiCoinImage;
    [Token(Token = "0x400D45F")]
    [FieldOffset(Offset = "0x28")]
    public Texture KakeraCoinImage;
    [Token(Token = "0x400D460")]
    [FieldOffset(Offset = "0x2C")]
    public Text ItemName;
    [Token(Token = "0x400D461")]
    [FieldOffset(Offset = "0x30")]
    public Text ItemNameNumTex;
    [Token(Token = "0x400D462")]
    [FieldOffset(Offset = "0x34")]
    public GameObject ItemFrameObj;

    [Token(Token = "0x600C6B5")]
    [Address(RVA = "0x8F2F70", Offset = "0x8F1D70", VA = "0x108F2F70")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C6B6")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TowerRewardUI()
    {
    }
  }
}

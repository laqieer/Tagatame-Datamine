// Decompiled with JetBrains decompiler
// Type: SRPG.GachaCoinChangeWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002421")]
  [AddComponentMenu("UI/GachaCoinChangeWindow")]
  public class GachaCoinChangeWindow : MonoBehaviour
  {
    [Token(Token = "0x400A397")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text ChangeText;
    [Token(Token = "0x400A398")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text CoinNum;
    [Token(Token = "0x400A399")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text StoneNum;
    [Token(Token = "0x400A39A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject OldIcon;
    [Token(Token = "0x400A39B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject NewIcon;

    [Token(Token = "0x6009D87")]
    [Address(RVA = "0x5FC590", Offset = "0x5FB390", VA = "0x105FC590")]
    public void Refresh(GachaCoinChangeWindow.CoinType coinType)
    {
    }

    [Token(Token = "0x6009D88")]
    [Address(RVA = "0x5FC170", Offset = "0x5FAF70", VA = "0x105FC170")]
    private void RefreshNewCoin()
    {
    }

    [Token(Token = "0x6009D89")]
    [Address(RVA = "0x5FC380", Offset = "0x5FB180", VA = "0x105FC380")]
    private void RefreshOldCoin()
    {
    }

    [Token(Token = "0x6009D8A")]
    [Address(RVA = "0x5FC5C0", Offset = "0x5FB3C0", VA = "0x105FC5C0")]
    private string ToDateString(long unixTime) => (string) null;

    [Token(Token = "0x6009D8B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GachaCoinChangeWindow()
    {
    }

    [Token(Token = "0x2002422")]
    public enum CoinType
    {
      [Token(Token = "0x400A39D")] New,
      [Token(Token = "0x400A39E")] Old,
    }
  }
}

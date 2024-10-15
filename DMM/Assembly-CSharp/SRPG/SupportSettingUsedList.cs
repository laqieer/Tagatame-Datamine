// Decompiled with JetBrains decompiler
// Type: SRPG.SupportSettingUsedList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B19")]
  [AddComponentMenu("UI/SupportSettingUsedList")]
  public class SupportSettingUsedList : MonoBehaviour
  {
    [Token(Token = "0x400D260")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mTextForm;
    [Token(Token = "0x400D261")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mTextTimes;
    [Token(Token = "0x400D262")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mTextLast;
    [Token(Token = "0x400D263")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mTextGold;
    [Token(Token = "0x400D264")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ImageArray mElement;
    [Token(Token = "0x400D265")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mLevel;
    [Token(Token = "0x400D266")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mOverGold;

    [Token(Token = "0x600C541")]
    [Address(RVA = "0x8DD810", Offset = "0x8DC610", VA = "0x108DD810")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C542")]
    [Address(RVA = "0x8DD870", Offset = "0x8DC670", VA = "0x108DD870")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C543")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public SupportSettingUsedList()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.CharacterLimitLineText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200213C")]
  public class CharacterLimitLineText : NoBreakSpaceText
  {
    [Token(Token = "0x40090AC")]
    [FieldOffset(Offset = "0x98")]
    [HideInInspector]
    public int LineCharacterLimitNum;
    [Token(Token = "0x40090AD")]
    [FieldOffset(Offset = "0x9C")]
    [HideInInspector]
    public InputFieldCensorshipLineAndSpace InputFiledObj;
    [Token(Token = "0x40090AE")]
    [FieldOffset(Offset = "0xA0")]
    [HideInInspector]
    public string ReferenceCharacter;
    [Token(Token = "0x40090AF")]
    [FieldOffset(Offset = "0xA4")]
    [HideInInspector]
    public bool JustHeightTextLengthFlag;
    [Token(Token = "0x40090B0")]
    [FieldOffset(Offset = "0xA8")]
    private float mCheckSceneWidth;
    [Token(Token = "0x40090B1")]
    [FieldOffset(Offset = "0xAC")]
    private float mCheckSceneHeight;
    [Token(Token = "0x40090B2")]
    [FieldOffset(Offset = "0xB0")]
    private string mNowText;
    [Token(Token = "0x40090B3")]
    [FieldOffset(Offset = "0xB4")]
    private bool mIsResizeCheck;

    [Token(Token = "0x170013B2")]
    public override string text
    {
      [Token(Token = "0x6008B74"), Address(RVA = "0x4F6600", Offset = "0x4F5400", VA = "0x104F6600", Slot = "74")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6008B75"), Address(RVA = "0x4F6610", Offset = "0x4F5410", VA = "0x104F6610", Slot = "75")] set
      {
      }
    }

    [Token(Token = "0x6008B76")]
    [Address(RVA = "0x4F6560", Offset = "0x4F5360", VA = "0x104F6560", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x6008B77")]
    [Address(RVA = "0x4F6350", Offset = "0x4F5150", VA = "0x104F6350")]
    private void ResizeTextArea()
    {
    }

    [Token(Token = "0x6008B78")]
    [Address(RVA = "0x4F6200", Offset = "0x4F5000", VA = "0x104F6200")]
    private void RangeDrawText(string _text)
    {
    }

    [Token(Token = "0x6008B79")]
    [Address(RVA = "0x4F6160", Offset = "0x4F4F60", VA = "0x104F6160")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x6008B7A")]
    [Address(RVA = "0x4F65B0", Offset = "0x4F53B0", VA = "0x104F65B0")]
    public CharacterLimitLineText()
    {
    }
  }
}

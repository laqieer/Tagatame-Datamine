// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDrawInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002995")]
  [AddComponentMenu("UI/Rune/RuneDrawInfo")]
  public class RuneDrawInfo : MonoBehaviour
  {
    [Token(Token = "0x400C8E8")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mRuneName;
    [Token(Token = "0x400C8E9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ImageArray mRuneSlotNumber;
    [Token(Token = "0x400C8EA")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mRuneSetEffName;
    [Token(Token = "0x400C8EB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mRuneSlotNumberText;
    [Token(Token = "0x400C8EC")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mRuneSetEffName2;
    [Token(Token = "0x400C8ED")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mRuneSlotNumberText2;
    [Token(Token = "0x400C8EE")]
    [FieldOffset(Offset = "0x24")]
    private BindRuneData mRuneData;

    [Token(Token = "0x600BC77")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BC78")]
    [Address(RVA = "0x841510", Offset = "0x840310", VA = "0x10841510")]
    public void SetDrawParam(BindRuneData rune_data)
    {
    }

    [Token(Token = "0x600BC79")]
    [Address(RVA = "0x841210", Offset = "0x840010", VA = "0x10841210")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BC7A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneDrawInfo()
    {
    }
  }
}

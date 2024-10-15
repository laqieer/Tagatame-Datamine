// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDrawSetEff
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002997")]
  [AddComponentMenu("UI/Rune/RuneDrawSetEff")]
  public class RuneDrawSetEff : MonoBehaviour
  {
    [Token(Token = "0x400C8F6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mSetEffParentOn;
    [Token(Token = "0x400C8F7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mSetEffParentOff;
    [Token(Token = "0x400C8F8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mSetEffWakeNum;
    [Token(Token = "0x400C8F9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StatusList mSetEffStatusList;
    [Token(Token = "0x400C8FA")]
    [FieldOffset(Offset = "0x1C")]
    private BindRuneData mRuneData;

    [Token(Token = "0x600BC7F")]
    [Address(RVA = "0x841BB0", Offset = "0x8409B0", VA = "0x10841BB0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BC80")]
    [Address(RVA = "0x841EF0", Offset = "0x840CF0", VA = "0x10841EF0")]
    public void SetDrawParam(BindRuneData rune_data)
    {
    }

    [Token(Token = "0x600BC81")]
    [Address(RVA = "0x841CF0", Offset = "0x840AF0", VA = "0x10841CF0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BC82")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneDrawSetEff()
    {
    }
  }
}

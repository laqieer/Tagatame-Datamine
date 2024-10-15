// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDrawEvoState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200298F")]
  [AddComponentMenu("UI/Rune/RuneDrawEvoState")]
  public class RuneDrawEvoState : MonoBehaviour
  {
    [Token(Token = "0x400C8C9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mEvoStatusParentOn;
    [Token(Token = "0x400C8CA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mEvoStatusParentOff;
    [Token(Token = "0x400C8CB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RuneDrawEvoStateOneSetting mEvoStateOne;
    [Token(Token = "0x400C8CC")]
    [FieldOffset(Offset = "0x18")]
    private BindRuneData mRuneData;
    [Token(Token = "0x400C8CD")]
    [FieldOffset(Offset = "0x1C")]
    private List<RuneDrawEvoStateOneSetting> mRuneEvoStatusList;
    [Token(Token = "0x400C8CE")]
    [FieldOffset(Offset = "0x20")]
    private ColorBlock mKeepButtonColor;
    [Token(Token = "0x400C8CF")]
    [FieldOffset(Offset = "0x78")]
    private bool mIsUseKeepButtonColor;

    [Token(Token = "0x14000010")]
    private event RuneDrawEvoState.OnSelectedEvent mOnSelectedEvent
    {
      [Token(Token = "0x600BC4E"), Address(RVA = "0x841110", Offset = "0x83FF10", VA = "0x10841110")] add
      {
      }
      [Token(Token = "0x600BC4F"), Address(RVA = "0x841190", Offset = "0x83FF90", VA = "0x10841190")] remove
      {
      }
    }

    [Token(Token = "0x600BC50")]
    [Address(RVA = "0x5A4130", Offset = "0x5A2F30", VA = "0x105A4130")]
    public void SetSelectedCallBack(RuneDrawEvoState.OnSelectedEvent selected)
    {
    }

    [Token(Token = "0x600BC51")]
    [Address(RVA = "0x840790", Offset = "0x83F590", VA = "0x10840790")]
    public void OnClickEvoItem(int index)
    {
    }

    [Token(Token = "0x600BC52")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BC53")]
    [Address(RVA = "0x840DE0", Offset = "0x83FBE0", VA = "0x10840DE0")]
    public void SetDrawParam(BindRuneData rune_data)
    {
    }

    [Token(Token = "0x600BC54")]
    [Address(RVA = "0x840E10", Offset = "0x83FC10", VA = "0x10840E10")]
    public void ShowFrame(bool is_show, int index = 0)
    {
    }

    [Token(Token = "0x600BC55")]
    [Address(RVA = "0x840B10", Offset = "0x83F910", VA = "0x10840B10")]
    public void SetDisableColor(bool is_hilight, int index)
    {
    }

    [Token(Token = "0x600BC56")]
    [Address(RVA = "0x840ED0", Offset = "0x83FCD0", VA = "0x10840ED0")]
    public void StartGaugeAnim(int index)
    {
    }

    [Token(Token = "0x600BC57")]
    [Address(RVA = "0x840A30", Offset = "0x83F830", VA = "0x10840A30")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BC58")]
    [Address(RVA = "0x840890", Offset = "0x83F690", VA = "0x10840890")]
    public void RefreshFrame()
    {
    }

    [Token(Token = "0x600BC59")]
    [Address(RVA = "0x8407C0", Offset = "0x83F5C0", VA = "0x108407C0")]
    public void RefreshEvoStatus()
    {
    }

    [Token(Token = "0x600BC5A")]
    [Address(RVA = "0x840170", Offset = "0x83EF70", VA = "0x10840170")]
    public void CloneEvoStatusList()
    {
    }

    [Token(Token = "0x600BC5B")]
    [Address(RVA = "0x8405C0", Offset = "0x83F3C0", VA = "0x108405C0")]
    public void DrawEvoStatusList()
    {
    }

    [Token(Token = "0x600BC5C")]
    [Address(RVA = "0x840F40", Offset = "0x83FD40", VA = "0x10840F40")]
    public RuneDrawEvoState()
    {
    }

    [Token(Token = "0x2002990")]
    public delegate void OnSelectedEvent(int index);
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceStarRewardWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F65")]
  [AddComponentMenu("UI/Advance/AdvanceStarRewardWindow")]
  public class AdvanceStarRewardWindow : MonoBehaviour
  {
    [Token(Token = "0x4008468")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mBodyText;
    [Token(Token = "0x4008469")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform mRewardIconParent;
    [Token(Token = "0x400846A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private AdvanceRewardIcon mRewardIconTemplate;
    [Token(Token = "0x400846B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button mReceiveButton;
    [Token(Token = "0x400846C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mButtonText;

    [Token(Token = "0x60080D9")]
    [Address(RVA = "0x417B00", Offset = "0x416900", VA = "0x10417B00")]
    private void Start()
    {
    }

    [Token(Token = "0x60080DA")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdvanceStarRewardWindow()
    {
    }
  }
}

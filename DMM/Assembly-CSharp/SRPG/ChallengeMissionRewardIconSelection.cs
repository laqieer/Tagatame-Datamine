// Decompiled with JetBrains decompiler
// Type: SRPG.ChallengeMissionRewardIconSelection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002134")]
  [AddComponentMenu("UI/ChallengeMissionRewardIconSelection")]
  public class ChallengeMissionRewardIconSelection : MonoBehaviour
  {
    [Token(Token = "0x400908F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject IconLarge;
    [Token(Token = "0x4009090")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject IconSmall;

    [Token(Token = "0x6008B5C")]
    [Address(RVA = "0x4F42E0", Offset = "0x4F30E0", VA = "0x104F42E0")]
    public void SetLarge(bool isLarge)
    {
    }

    [Token(Token = "0x6008B5D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ChallengeMissionRewardIconSelection()
    {
    }
  }
}

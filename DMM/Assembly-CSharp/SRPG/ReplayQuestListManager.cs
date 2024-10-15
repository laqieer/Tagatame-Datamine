// Decompiled with JetBrains decompiler
// Type: SRPG.ReplayQuestListManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002948")]
  [AddComponentMenu("UI/ReplayQuestListManager")]
  public class ReplayQuestListManager : MonoBehaviour
  {
    [Token(Token = "0x400C6E2")]
    [FieldOffset(Offset = "0x0")]
    private static ReplayQuestListManager mInstance;
    [Token(Token = "0x400C6E3")]
    [FieldOffset(Offset = "0xC")]
    private List<string> mPlayableScenario;

    [Token(Token = "0x1700196A")]
    public static ReplayQuestListManager Instance
    {
      [Token(Token = "0x600BAB6"), Address(RVA = "0x8217C0", Offset = "0x8205C0", VA = "0x108217C0")] get
      {
        return (ReplayQuestListManager) null;
      }
    }

    [Token(Token = "0x600BAB7")]
    [Address(RVA = "0x821530", Offset = "0x820330", VA = "0x10821530")]
    private void Awake()
    {
    }

    [Token(Token = "0x1700196B")]
    public List<string> PlayableScenario
    {
      [Token(Token = "0x600BAB8"), Address(RVA = "0x8217F0", Offset = "0x8205F0", VA = "0x108217F0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x600BAB9")]
    [Address(RVA = "0x821570", Offset = "0x820370", VA = "0x10821570")]
    public static List<string> GetPlayableReplayScenario() => (List<string>) null;

    [Token(Token = "0x600BABA")]
    [Address(RVA = "0x821780", Offset = "0x820580", VA = "0x10821780")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BABB")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ReplayQuestListManager()
    {
    }
  }
}

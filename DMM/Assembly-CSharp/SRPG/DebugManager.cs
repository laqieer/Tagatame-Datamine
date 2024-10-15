// Decompiled with JetBrains decompiler
// Type: SRPG.DebugManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018B9")]
  [AddComponentMenu("Scripts/SRPG/Manager/Debug")]
  [ExecuteInEditMode]
  public class DebugManager : MonoSingleton<DebugManager>
  {
    [Token(Token = "0x400589F")]
    [FieldOffset(Offset = "0xC")]
    private float mLastCollectNum;
    [Token(Token = "0x40058A0")]
    [FieldOffset(Offset = "0x10")]
    private long mAllocMem;
    [Token(Token = "0x40058A1")]
    [FieldOffset(Offset = "0x18")]
    private long mAllocPeak;

    [Token(Token = "0x170009C8")]
    public bool IsShowed
    {
      [Token(Token = "0x6006362"), Address(RVA = "0x305F50", Offset = "0x304D50", VA = "0x10305F50")] set
      {
      }
      [Token(Token = "0x6006363"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170009C9")]
    public bool IsShowedInEditor
    {
      [Token(Token = "0x6006364"), Address(RVA = "0x305F40", Offset = "0x304D40", VA = "0x10305F40")] set
      {
      }
      [Token(Token = "0x6006365"), Address(RVA = "0x305F20", Offset = "0x304D20", VA = "0x10305F20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6006366")]
    [Address(RVA = "0x305E00", Offset = "0x304C00", VA = "0x10305E00", Slot = "4")]
    protected override void Initialize()
    {
    }

    [Token(Token = "0x6006367")]
    [Address(RVA = "0x305E50", Offset = "0x304C50", VA = "0x10305E50")]
    private void Update()
    {
    }

    [Token(Token = "0x6006368")]
    [Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0")]
    public bool IsWebViewEnable() => new bool();

    [Token(Token = "0x6006369")]
    [Address(RVA = "0x305EE0", Offset = "0x304CE0", VA = "0x10305EE0")]
    public DebugManager()
    {
    }
  }
}

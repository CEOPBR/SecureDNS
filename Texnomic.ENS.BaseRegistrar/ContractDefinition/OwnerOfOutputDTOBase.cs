﻿using Nethereum.ABI.FunctionEncoding.Attributes;

namespace Texnomic.ENS.BaseRegistrar.ContractDefinition;

[FunctionOutput]
public class OwnerOfOutputDtoBase : IFunctionOutputDTO
{
    [Parameter("address", "", 1)]
    public virtual string ReturnValue1 { get; set; }
}
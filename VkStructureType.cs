namespace ApiSpec {
    // Enum: 126
    /// <summary>VkStructureType - Vulkan structure types (<code>stype</code>)</summary>
    public enum VkStructureType {
        ApplicationInfo = 0,
        InstanceCreateInfo = 1,
        DeviceQueueCreateInfo = 2,
        DeviceCreateInfo = 3,
        SubmitInfo = 4,
        MemoryAllocateInfo = 5,
        MappedMemoryRange = 6,
        BindSparseInfo = 7,
        FenceCreateInfo = 8,
        SemaphoreCreateInfo = 9,
        EventCreateInfo = 10,
        QueryPoolCreateInfo = 11,
        BufferCreateInfo = 12,
        BufferViewCreateInfo = 13,
        ImageCreateInfo = 14,
        ImageViewCreateInfo = 15,
        ShaderModuleCreateInfo = 16,
        PipelineCacheCreateInfo = 17,
        PipelineShaderStageCreateInfo = 18,
        PipelineVertexInputStateCreateInfo = 19,
        PipelineInputAssemblyStateCreateInfo = 20,
        PipelineTessellationStateCreateInfo = 21,
        PipelineViewportStateCreateInfo = 22,
        PipelineRasterizationStateCreateInfo = 23,
        PipelineMultisampleStateCreateInfo = 24,
        PipelineDepthStencilStateCreateInfo = 25,
        PipelineColorBlendStateCreateInfo = 26,
        PipelineDynamicStateCreateInfo = 27,
        GraphicsPipelineCreateInfo = 28,
        ComputePipelineCreateInfo = 29,
        PipelineLayoutCreateInfo = 30,
        SamplerCreateInfo = 31,
        DescriptorSetLayoutCreateInfo = 32,
        DescriptorPoolCreateInfo = 33,
        DescriptorSetAllocateInfo = 34,
        WriteDescriptorSet = 35,
        CopyDescriptorSet = 36,
        FramebufferCreateInfo = 37,
        RenderPassCreateInfo = 38,
        CommandPoolCreateInfo = 39,
        CommandBufferAllocateInfo = 40,
        CommandBufferInheritanceInfo = 41,
        CommandBufferBeginInfo = 42,
        RenderPassBeginInfo = 43,
        BufferMemoryBarrier = 44,
        ImageMemoryBarrier = 45,
        MemoryBarrier = 46,
        /// <summary>The values VK_STRUCTURE_TYPE_LOADER_INSTANCE_CREATE_INFO and
        /// VK_STRUCTURE_TYPE_LOADER_DEVICE_CREATE_INFO are reserved for internal
        /// use by the loader, and do not have corresponding Vulkan structures in this
        /// Specification.</summary>
        LoaderInstanceCreateInfo = 47,
        LoaderDeviceCreateInfo = 48,
        PhysicalDeviceSubgroupProperties = 1000094000,
        BindBufferMemoryInfo = 1000157000,
        BindImageMemoryInfo = 1000157001,
        PhysicalDevice16bitStorageFeatures = 1000083000,
        MemoryDedicatedRequirements = 1000127000,
        MemoryDedicatedAllocateInfo = 1000127001,
        MemoryAllocateFlagsInfo = 1000060000,
        DeviceGroupRenderPassBeginInfo = 1000060003,
        DeviceGroupCommandBufferBeginInfo = 1000060004,
        DeviceGroupSubmitInfo = 1000060005,
        DeviceGroupBindSparseInfo = 1000060006,
        BindBufferMemoryDeviceGroupInfo = 1000060013,
        BindImageMemoryDeviceGroupInfo = 1000060014,
        PhysicalDeviceGroupProperties = 1000070000,
        DeviceGroupDeviceCreateInfo = 1000070001,
        BufferMemoryRequirementsInfo2 = 1000146000,
        ImageMemoryRequirementsInfo2 = 1000146001,
        ImageSparseMemoryRequirementsInfo2 = 1000146002,
        MemoryRequirements2 = 1000146003,
        SparseImageMemoryRequirements2 = 1000146004,
        PhysicalDeviceFeatures2 = 1000059000,
        PhysicalDeviceProperties2 = 1000059001,
        FormatProperties2 = 1000059002,
        ImageFormatProperties2 = 1000059003,
        PhysicalDeviceImageFormatInfo2 = 1000059004,
        QueueFamilyProperties2 = 1000059005,
        PhysicalDeviceMemoryProperties2 = 1000059006,
        SparseImageFormatProperties2 = 1000059007,
        PhysicalDeviceSparseImageFormatInfo2 = 1000059008,
        PhysicalDevicePointClippingProperties = 1000117000,
        RenderPassInputAttachmentAspectCreateInfo = 1000117001,
        ImageViewUsageCreateInfo = 1000117002,
        PipelineTessellationDomainOriginStateCreateInfo = 1000117003,
        RenderPassMultiviewCreateInfo = 1000053000,
        PhysicalDeviceMultiviewFeatures = 1000053001,
        PhysicalDeviceMultiviewProperties = 1000053002,
        PhysicalDeviceVariablePointersFeatures = 1000120000,
        ProtectedSubmitInfo = 1000145000,
        PhysicalDeviceProtectedMemoryFeatures = 1000145001,
        PhysicalDeviceProtectedMemoryProperties = 1000145002,
        DeviceQueueInfo2 = 1000145003,
        SamplerYcbcrConversionCreateInfo = 1000156000,
        SamplerYcbcrConversionInfo = 1000156001,
        BindImagePlaneMemoryInfo = 1000156002,
        ImagePlaneMemoryRequirementsInfo = 1000156003,
        PhysicalDeviceSamplerYcbcrConversionFeatures = 1000156004,
        SamplerYcbcrConversionImageFormatProperties = 1000156005,
        DescriptorUpdateTemplateCreateInfo = 1000085000,
        PhysicalDeviceExternalImageFormatInfo = 1000071000,
        ExternalImageFormatProperties = 1000071001,
        PhysicalDeviceExternalBufferInfo = 1000071002,
        ExternalBufferProperties = 1000071003,
        PhysicalDeviceIdProperties = 1000071004,
        ExternalMemoryBufferCreateInfo = 1000072000,
        ExternalMemoryImageCreateInfo = 1000072001,
        ExportMemoryAllocateInfo = 1000072002,
        PhysicalDeviceExternalFenceInfo = 1000112000,
        ExternalFenceProperties = 1000112001,
        ExportFenceCreateInfo = 1000113000,
        ExportSemaphoreCreateInfo = 1000077000,
        PhysicalDeviceExternalSemaphoreInfo = 1000076000,
        ExternalSemaphoreProperties = 1000076001,
        PhysicalDeviceMaintenance3Properties = 1000168000,
        DescriptorSetLayoutSupport = 1000168001,
        PhysicalDeviceShaderDrawParametersFeatures = 1000063000,
        SwapchainCreateInfoKHR = 1000001000,
        PresentInfoKHR = 1000001001,
        DeviceGroupPresentCapabilitiesKHR = 1000060007,
        ImageSwapchainCreateInfoKHR = 1000060008,
        BindImageMemorySwapchainInfoKHR = 1000060009,
        AcquireNextImageInfoKHR = 1000060010,
        DeviceGroupPresentInfoKHR = 1000060011,
        DeviceGroupSwapchainCreateInfoKHR = 1000060012,
        DisplayModeCreateInfoKHR = 1000002000,
        DisplaySurfaceCreateInfoKHR = 1000002001,
        DisplayPresentInfoKHR = 1000003000,
        XlibSurfaceCreateInfoKHR = 1000004000,
        XcbSurfaceCreateInfoKHR = 1000005000,
        WaylandSurfaceCreateInfoKHR = 1000006000,
        AndroidSurfaceCreateInfoKHR = 1000008000,
        Win32SurfaceCreateInfoKHR = 1000009000,
        DebugReportCallbackCreateInfoEXT = 1000011000,
        PipelineRasterizationStateRasterizationOrderAmd = 1000018000,
        DebugMarkerObjectNameInfoEXT = 1000022000,
        DebugMarkerObjectTagInfoEXT = 1000022001,
        DebugMarkerMarkerInfoEXT = 1000022002,
        DedicatedAllocationImageCreateInfoNV = 1000026000,
        DedicatedAllocationBufferCreateInfoNV = 1000026001,
        DedicatedAllocationMemoryAllocateInfoNV = 1000026002,
        PhysicalDeviceTransformFeedbackFeaturesEXT = 1000028000,
        PhysicalDeviceTransformFeedbackPropertiesEXT = 1000028001,
        PipelineRasterizationStateStreamCreateInfoEXT = 1000028002,
        ImageViewHandleInfoNvx = 1000030000,
        TextureLodGatherFormatPropertiesAmd = 1000041000,
        StreamDescriptorSurfaceCreateInfoGgp = 1000049000,
        PhysicalDeviceCornerSampledImageFeaturesNV = 1000050000,
        ExternalMemoryImageCreateInfoNV = 1000056000,
        ExportMemoryAllocateInfoNV = 1000056001,
        ImportMemoryWin32HandleInfoNV = 1000057000,
        ExportMemoryWin32HandleInfoNV = 1000057001,
        Win32KeyedMutexAcquireReleaseInfoNV = 1000058000,
        ValidationFlagsEXT = 1000061000,
        ViSurfaceCreateInfoNn = 1000062000,
        ImageViewAstcDecodeModeEXT = 1000067000,
        PhysicalDeviceAstcDecodeFeaturesEXT = 1000067001,
        ImportMemoryWin32HandleInfoKHR = 1000073000,
        ExportMemoryWin32HandleInfoKHR = 1000073001,
        MemoryWin32HandlePropertiesKHR = 1000073002,
        MemoryGetWin32HandleInfoKHR = 1000073003,
        ImportMemoryFdInfoKHR = 1000074000,
        MemoryFdPropertiesKHR = 1000074001,
        MemoryGetFdInfoKHR = 1000074002,
        Win32KeyedMutexAcquireReleaseInfoKHR = 1000075000,
        ImportSemaphoreWin32HandleInfoKHR = 1000078000,
        ExportSemaphoreWin32HandleInfoKHR = 1000078001,
        D3d12FenceSubmitInfoKHR = 1000078002,
        SemaphoreGetWin32HandleInfoKHR = 1000078003,
        ImportSemaphoreFdInfoKHR = 1000079000,
        SemaphoreGetFdInfoKHR = 1000079001,
        PhysicalDevicePushDescriptorPropertiesKHR = 1000080000,
        CommandBufferInheritanceConditionalRenderingInfoEXT = 1000081000,
        PhysicalDeviceConditionalRenderingFeaturesEXT = 1000081001,
        ConditionalRenderingBeginInfoEXT = 1000081002,
        PhysicalDeviceFloat16Int8FeaturesKHR = 1000082000,
        PresentRegionsKHR = 1000084000,
        ObjectTableCreateInfoNvx = 1000086000,
        IndirectCommandsLayoutCreateInfoNvx = 1000086001,
        CmdProcessCommandsInfoNvx = 1000086002,
        CmdReserveSpaceForCommandsInfoNvx = 1000086003,
        DeviceGeneratedCommandsLimitsNvx = 1000086004,
        DeviceGeneratedCommandsFeaturesNvx = 1000086005,
        PipelineViewportWScalingStateCreateInfoNV = 1000087000,
        SurfaceCapabilities2EXT = 1000090000,
        DisplayPowerInfoEXT = 1000091000,
        DeviceEventInfoEXT = 1000091001,
        DisplayEventInfoEXT = 1000091002,
        SwapchainCounterCreateInfoEXT = 1000091003,
        PresentTimesInfoGoogle = 1000092000,
        PhysicalDeviceMultiviewPerViewAttributesPropertiesNvx = 1000097000,
        PipelineViewportSwizzleStateCreateInfoNV = 1000098000,
        PhysicalDeviceDiscardRectanglePropertiesEXT = 1000099000,
        PipelineDiscardRectangleStateCreateInfoEXT = 1000099001,
        PhysicalDeviceConservativeRasterizationPropertiesEXT = 1000101000,
        PipelineRasterizationConservativeStateCreateInfoEXT = 1000101001,
        PhysicalDeviceDepthClipEnableFeaturesEXT = 1000102000,
        PipelineRasterizationDepthClipStateCreateInfoEXT = 1000102001,
        HdrMetadataEXT = 1000105000,
        AttachmentDescription2KHR = 1000109000,
        AttachmentReference2KHR = 1000109001,
        SubpassDescription2KHR = 1000109002,
        SubpassDependency2KHR = 1000109003,
        RenderPassCreateInfo2KHR = 1000109004,
        SubpassBeginInfoKHR = 1000109005,
        SubpassEndInfoKHR = 1000109006,
        SharedPresentSurfaceCapabilitiesKHR = 1000111000,
        ImportFenceWin32HandleInfoKHR = 1000114000,
        ExportFenceWin32HandleInfoKHR = 1000114001,
        FenceGetWin32HandleInfoKHR = 1000114002,
        ImportFenceFdInfoKHR = 1000115000,
        FenceGetFdInfoKHR = 1000115001,
        PhysicalDeviceSurfaceInfo2KHR = 1000119000,
        SurfaceCapabilities2KHR = 1000119001,
        SurfaceFormat2KHR = 1000119002,
        DisplayProperties2KHR = 1000121000,
        DisplayPlaneProperties2KHR = 1000121001,
        DisplayModeProperties2KHR = 1000121002,
        DisplayPlaneInfo2KHR = 1000121003,
        DisplayPlaneCapabilities2KHR = 1000121004,
        IosSurfaceCreateInfoMvk = 1000122000,
        MacosSurfaceCreateInfoMvk = 1000123000,
        DebugUtilsObjectNameInfoEXT = 1000128000,
        DebugUtilsObjectTagInfoEXT = 1000128001,
        DebugUtilsLabelEXT = 1000128002,
        DebugUtilsMessengerCallbackDataEXT = 1000128003,
        DebugUtilsMessengerCreateInfoEXT = 1000128004,
        AndroidHardwareBufferUsageAndroid = 1000129000,
        AndroidHardwareBufferPropertiesAndroid = 1000129001,
        AndroidHardwareBufferFormatPropertiesAndroid = 1000129002,
        ImportAndroidHardwareBufferInfoAndroid = 1000129003,
        MemoryGetAndroidHardwareBufferInfoAndroid = 1000129004,
        ExternalFormatAndroid = 1000129005,
        PhysicalDeviceSamplerFilterMinmaxPropertiesEXT = 1000130000,
        SamplerReductionModeCreateInfoEXT = 1000130001,
        PhysicalDeviceInlineUniformBlockFeaturesEXT = 1000138000,
        PhysicalDeviceInlineUniformBlockPropertiesEXT = 1000138001,
        WriteDescriptorSetInlineUniformBlockEXT = 1000138002,
        DescriptorPoolInlineUniformBlockCreateInfoEXT = 1000138003,
        SampleLocationsInfoEXT = 1000143000,
        RenderPassSampleLocationsBeginInfoEXT = 1000143001,
        PipelineSampleLocationsStateCreateInfoEXT = 1000143002,
        PhysicalDeviceSampleLocationsPropertiesEXT = 1000143003,
        MultisamplePropertiesEXT = 1000143004,
        ImageFormatListCreateInfoKHR = 1000147000,
        PhysicalDeviceBlendOperationAdvancedFeaturesEXT = 1000148000,
        PhysicalDeviceBlendOperationAdvancedPropertiesEXT = 1000148001,
        PipelineColorBlendAdvancedStateCreateInfoEXT = 1000148002,
        PipelineCoverageToColorStateCreateInfoNV = 1000149000,
        PipelineCoverageModulationStateCreateInfoNV = 1000152000,
        DrmFormatModifierPropertiesListEXT = 1000158000,
        DrmFormatModifierPropertiesEXT = 1000158001,
        PhysicalDeviceImageDrmFormatModifierInfoEXT = 1000158002,
        ImageDrmFormatModifierListCreateInfoEXT = 1000158003,
        ImageDrmFormatModifierExplicitCreateInfoEXT = 1000158004,
        ImageDrmFormatModifierPropertiesEXT = 1000158005,
        ValidationCacheCreateInfoEXT = 1000160000,
        ShaderModuleValidationCacheCreateInfoEXT = 1000160001,
        DescriptorSetLayoutBindingFlagsCreateInfoEXT = 1000161000,
        PhysicalDeviceDescriptorIndexingFeaturesEXT = 1000161001,
        PhysicalDeviceDescriptorIndexingPropertiesEXT = 1000161002,
        DescriptorSetVariableDescriptorCountAllocateInfoEXT = 1000161003,
        DescriptorSetVariableDescriptorCountLayoutSupportEXT = 1000161004,
        PipelineViewportShadingRateImageStateCreateInfoNV = 1000164000,
        PhysicalDeviceShadingRateImageFeaturesNV = 1000164001,
        PhysicalDeviceShadingRateImagePropertiesNV = 1000164002,
        PipelineViewportCoarseSampleOrderStateCreateInfoNV = 1000164005,
        RayTracingPipelineCreateInfoNV = 1000165000,
        AccelerationStructureCreateInfoNV = 1000165001,
        GeometryNV = 1000165003,
        GeometryTrianglesNV = 1000165004,
        GeometryAabbNV = 1000165005,
        BindAccelerationStructureMemoryInfoNV = 1000165006,
        WriteDescriptorSetAccelerationStructureNV = 1000165007,
        AccelerationStructureMemoryRequirementsInfoNV = 1000165008,
        PhysicalDeviceRayTracingPropertiesNV = 1000165009,
        RayTracingShaderGroupCreateInfoNV = 1000165011,
        AccelerationStructureInfoNV = 1000165012,
        PhysicalDeviceRepresentativeFragmentTestFeaturesNV = 1000166000,
        PipelineRepresentativeFragmentTestStateCreateInfoNV = 1000166001,
        PhysicalDeviceImageViewImageFormatInfoEXT = 1000170000,
        FilterCubicImageViewImageFormatPropertiesEXT = 1000170001,
        DeviceQueueGlobalPriorityCreateInfoEXT = 1000174000,
        PhysicalDevice8bitStorageFeaturesKHR = 1000177000,
        ImportMemoryHostPointerInfoEXT = 1000178000,
        MemoryHostPointerPropertiesEXT = 1000178001,
        PhysicalDeviceExternalMemoryHostPropertiesEXT = 1000178002,
        PhysicalDeviceShaderAtomicInt64FeaturesKHR = 1000180000,
        CalibratedTimestampInfoEXT = 1000184000,
        PhysicalDeviceShaderCorePropertiesAmd = 1000185000,
        DeviceMemoryOverallocationCreateInfoAmd = 1000189000,
        PhysicalDeviceVertexAttributeDivisorPropertiesEXT = 1000190000,
        PipelineVertexInputDivisorStateCreateInfoEXT = 1000190001,
        PhysicalDeviceVertexAttributeDivisorFeaturesEXT = 1000190002,
        PresentFrameTokenGgp = 1000191000,
        PipelineCreationFeedbackCreateInfoEXT = 1000192000,
        PhysicalDeviceDriverPropertiesKHR = 1000196000,
        PhysicalDeviceFloatControlsPropertiesKHR = 1000197000,
        PhysicalDeviceDepthStencilResolvePropertiesKHR = 1000199000,
        SubpassDescriptionDepthStencilResolveKHR = 1000199001,
        PhysicalDeviceComputeShaderDerivativesFeaturesNV = 1000201000,
        PhysicalDeviceMeshShaderFeaturesNV = 1000202000,
        PhysicalDeviceMeshShaderPropertiesNV = 1000202001,
        PhysicalDeviceFragmentShaderBarycentricFeaturesNV = 1000203000,
        PhysicalDeviceShaderImageFootprintFeaturesNV = 1000204000,
        PipelineViewportExclusiveScissorStateCreateInfoNV = 1000205000,
        PhysicalDeviceExclusiveScissorFeaturesNV = 1000205002,
        CheckpointDataNV = 1000206000,
        QueueFamilyCheckpointPropertiesNV = 1000206001,
        PhysicalDeviceVulkanMemoryModelFeaturesKHR = 1000211000,
        PhysicalDevicePciBusInfoPropertiesEXT = 1000212000,
        DisplayNativeHdrSurfaceCapabilitiesAmd = 1000213000,
        SwapchainDisplayNativeHdrCreateInfoAmd = 1000213001,
        ImagepipeSurfaceCreateInfoFuchsia = 1000214000,
        MetalSurfaceCreateInfoEXT = 1000217000,
        PhysicalDeviceFragmentDensityMapFeaturesEXT = 1000218000,
        PhysicalDeviceFragmentDensityMapPropertiesEXT = 1000218001,
        RenderPassFragmentDensityMapCreateInfoEXT = 1000218002,
        PhysicalDeviceScalarBlockLayoutFeaturesEXT = 1000221000,
        PhysicalDeviceMemoryBudgetPropertiesEXT = 1000237000,
        PhysicalDeviceMemoryPriorityFeaturesEXT = 1000238000,
        MemoryPriorityAllocateInfoEXT = 1000238001,
        SurfaceProtectedCapabilitiesKHR = 1000239000,
        PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV = 1000240000,
        PhysicalDeviceBufferDeviceAddressFeaturesEXT = 1000244000,
        BufferDeviceAddressInfoEXT = 1000244001,
        BufferDeviceAddressCreateInfoEXT = 1000244002,
        ImageStencilUsageCreateInfoEXT = 1000246000,
        ValidationFeaturesEXT = 1000247000,
        PhysicalDeviceCooperativeMatrixFeaturesNV = 1000249000,
        CooperativeMatrixPropertiesNV = 1000249001,
        PhysicalDeviceCooperativeMatrixPropertiesNV = 1000249002,
        PhysicalDeviceYcbcrImageArraysFeaturesEXT = 1000252000,
        SurfaceFullScreenExclusiveInfoEXT = 1000255000,
        SurfaceCapabilitiesFullScreenExclusiveEXT = 1000255002,
        SurfaceFullScreenExclusiveWin32InfoEXT = 1000255001,
        PhysicalDeviceHostQueryResetFeaturesEXT = 1000261000,
        PhysicalDeviceVariablePointerFeatures = PhysicalDeviceVariablePointersFeatures,
        PhysicalDeviceShaderDrawParameterFeatures = PhysicalDeviceShaderDrawParametersFeatures,
        DebugReportCreateInfoEXT = DebugReportCallbackCreateInfoEXT,
        RenderPassMultiviewCreateInfoKHR = RenderPassMultiviewCreateInfo,
        PhysicalDeviceMultiviewFeaturesKHR = PhysicalDeviceMultiviewFeatures,
        PhysicalDeviceMultiviewPropertiesKHR = PhysicalDeviceMultiviewProperties,
        PhysicalDeviceFeatures2KHR = PhysicalDeviceFeatures2,
        PhysicalDeviceProperties2KHR = PhysicalDeviceProperties2,
        FormatProperties2KHR = FormatProperties2,
        ImageFormatProperties2KHR = ImageFormatProperties2,
        PhysicalDeviceImageFormatInfo2KHR = PhysicalDeviceImageFormatInfo2,
        QueueFamilyProperties2KHR = QueueFamilyProperties2,
        PhysicalDeviceMemoryProperties2KHR = PhysicalDeviceMemoryProperties2,
        SparseImageFormatProperties2KHR = SparseImageFormatProperties2,
        PhysicalDeviceSparseImageFormatInfo2KHR = PhysicalDeviceSparseImageFormatInfo2,
        MemoryAllocateFlagsInfoKHR = MemoryAllocateFlagsInfo,
        DeviceGroupRenderPassBeginInfoKHR = DeviceGroupRenderPassBeginInfo,
        DeviceGroupCommandBufferBeginInfoKHR = DeviceGroupCommandBufferBeginInfo,
        DeviceGroupSubmitInfoKHR = DeviceGroupSubmitInfo,
        DeviceGroupBindSparseInfoKHR = DeviceGroupBindSparseInfo,
        BindBufferMemoryDeviceGroupInfoKHR = BindBufferMemoryDeviceGroupInfo,
        BindImageMemoryDeviceGroupInfoKHR = BindImageMemoryDeviceGroupInfo,
        PhysicalDeviceGroupPropertiesKHR = PhysicalDeviceGroupProperties,
        DeviceGroupDeviceCreateInfoKHR = DeviceGroupDeviceCreateInfo,
        PhysicalDeviceExternalImageFormatInfoKHR = PhysicalDeviceExternalImageFormatInfo,
        ExternalImageFormatPropertiesKHR = ExternalImageFormatProperties,
        PhysicalDeviceExternalBufferInfoKHR = PhysicalDeviceExternalBufferInfo,
        ExternalBufferPropertiesKHR = ExternalBufferProperties,
        PhysicalDeviceIdPropertiesKHR = PhysicalDeviceIdProperties,
        ExternalMemoryBufferCreateInfoKHR = ExternalMemoryBufferCreateInfo,
        ExternalMemoryImageCreateInfoKHR = ExternalMemoryImageCreateInfo,
        ExportMemoryAllocateInfoKHR = ExportMemoryAllocateInfo,
        PhysicalDeviceExternalSemaphoreInfoKHR = PhysicalDeviceExternalSemaphoreInfo,
        ExternalSemaphorePropertiesKHR = ExternalSemaphoreProperties,
        ExportSemaphoreCreateInfoKHR = ExportSemaphoreCreateInfo,
        PhysicalDevice16bitStorageFeaturesKHR = PhysicalDevice16bitStorageFeatures,
        DescriptorUpdateTemplateCreateInfoKHR = DescriptorUpdateTemplateCreateInfo,

        PhysicalDeviceExternalFenceInfoKHR = PhysicalDeviceExternalFenceInfo,
        ExternalFencePropertiesKHR = ExternalFenceProperties,
        ExportFenceCreateInfoKHR = ExportFenceCreateInfo,
        PhysicalDevicePointClippingPropertiesKHR = PhysicalDevicePointClippingProperties,
        RenderPassInputAttachmentAspectCreateInfoKHR = RenderPassInputAttachmentAspectCreateInfo,
        ImageViewUsageCreateInfoKHR = ImageViewUsageCreateInfo,
        PipelineTessellationDomainOriginStateCreateInfoKHR = PipelineTessellationDomainOriginStateCreateInfo,
        PhysicalDeviceVariablePointerFeaturesKHR = PhysicalDeviceVariablePointerFeatures,
        PhysicalDeviceVariablePointersFeaturesKHR = PhysicalDeviceVariablePointerFeatures,
        MemoryDedicatedRequirementsKHR = MemoryDedicatedRequirements,
        MemoryDedicatedAllocateInfoKHR = MemoryDedicatedAllocateInfo,
        BufferMemoryRequirementsInfo2KHR = BufferMemoryRequirementsInfo2,
        ImageMemoryRequirementsInfo2KHR = ImageMemoryRequirementsInfo2,
        ImageSparseMemoryRequirementsInfo2KHR = ImageSparseMemoryRequirementsInfo2,
        MemoryRequirements2KHR = MemoryRequirements2,
        SparseImageMemoryRequirements2KHR = SparseImageMemoryRequirements2,
        SamplerYcbcrConversionCreateInfoKHR = SamplerYcbcrConversionCreateInfo,
        SamplerYcbcrConversionInfoKHR = SamplerYcbcrConversionInfo,
        BindImagePlaneMemoryInfoKHR = BindImagePlaneMemoryInfo,
        ImagePlaneMemoryRequirementsInfoKHR = ImagePlaneMemoryRequirementsInfo,
        PhysicalDeviceSamplerYcbcrConversionFeaturesKHR = PhysicalDeviceSamplerYcbcrConversionFeatures,
        SamplerYcbcrConversionImageFormatPropertiesKHR = SamplerYcbcrConversionImageFormatProperties,
        BindBufferMemoryInfoKHR = BindBufferMemoryInfo,
        BindImageMemoryInfoKHR = BindImageMemoryInfo,
        PhysicalDeviceMaintenance3PropertiesKHR = PhysicalDeviceMaintenance3Properties,
        DescriptorSetLayoutSupportKHR = DescriptorSetLayoutSupport,
        PhysicalDeviceBufferAddressFeaturesEXT = PhysicalDeviceBufferDeviceAddressFeaturesEXT,
        MaxEnum = 0x7FFFFFFF,
    }
}
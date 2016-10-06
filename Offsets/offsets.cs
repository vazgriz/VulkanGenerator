#include<iostream>
#include<vulkan/vulkan.h>

int main() {
    std::cout << "VkOffset2D" << std::endl;
        std::cout << "x: " << offsetof(VkOffset2D, x) << std::endl;
        std::cout << "y: " << offsetof(VkOffset2D, y) << std::endl;
    std::cout << std::endl;

    std::cout << "VkOffset3D" << std::endl;
        std::cout << "x: " << offsetof(VkOffset3D, x) << std::endl;
        std::cout << "y: " << offsetof(VkOffset3D, y) << std::endl;
        std::cout << "z: " << offsetof(VkOffset3D, z) << std::endl;
    std::cout << std::endl;

    std::cout << "VkExtent2D" << std::endl;
        std::cout << "width: " << offsetof(VkExtent2D, width) << std::endl;
        std::cout << "height: " << offsetof(VkExtent2D, height) << std::endl;
    std::cout << std::endl;

    std::cout << "VkExtent3D" << std::endl;
        std::cout << "width: " << offsetof(VkExtent3D, width) << std::endl;
        std::cout << "height: " << offsetof(VkExtent3D, height) << std::endl;
        std::cout << "depth: " << offsetof(VkExtent3D, depth) << std::endl;
    std::cout << std::endl;

    std::cout << "VkViewport" << std::endl;
        std::cout << "x: " << offsetof(VkViewport, x) << std::endl;
        std::cout << "y: " << offsetof(VkViewport, y) << std::endl;
        std::cout << "width: " << offsetof(VkViewport, width) << std::endl;
        std::cout << "height: " << offsetof(VkViewport, height) << std::endl;
        std::cout << "minDepth: " << offsetof(VkViewport, minDepth) << std::endl;
        std::cout << "maxDepth: " << offsetof(VkViewport, maxDepth) << std::endl;
    std::cout << std::endl;

    std::cout << "VkRect2D" << std::endl;
        std::cout << "offset: " << offsetof(VkRect2D, offset) << std::endl;
        std::cout << "extent: " << offsetof(VkRect2D, extent) << std::endl;
    std::cout << std::endl;

    std::cout << "VkRect3D" << std::endl;
        std::cout << "offset: " << offsetof(VkRect3D, offset) << std::endl;
        std::cout << "extent: " << offsetof(VkRect3D, extent) << std::endl;
    std::cout << std::endl;

    std::cout << "VkClearRect" << std::endl;
        std::cout << "rect: " << offsetof(VkClearRect, rect) << std::endl;
        std::cout << "baseArrayLayer: " << offsetof(VkClearRect, baseArrayLayer) << std::endl;
        std::cout << "layerCount: " << offsetof(VkClearRect, layerCount) << std::endl;
    std::cout << std::endl;

    std::cout << "VkComponentMapping" << std::endl;
        std::cout << "r: " << offsetof(VkComponentMapping, r) << std::endl;
        std::cout << "g: " << offsetof(VkComponentMapping, g) << std::endl;
        std::cout << "b: " << offsetof(VkComponentMapping, b) << std::endl;
        std::cout << "a: " << offsetof(VkComponentMapping, a) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPhysicalDeviceProperties" << std::endl;
        std::cout << "apiVersion: " << offsetof(VkPhysicalDeviceProperties, apiVersion) << std::endl;
        std::cout << "driverVersion: " << offsetof(VkPhysicalDeviceProperties, driverVersion) << std::endl;
        std::cout << "vendorID: " << offsetof(VkPhysicalDeviceProperties, vendorID) << std::endl;
        std::cout << "deviceID: " << offsetof(VkPhysicalDeviceProperties, deviceID) << std::endl;
        std::cout << "deviceType: " << offsetof(VkPhysicalDeviceProperties, deviceType) << std::endl;
        std::cout << "deviceName: " << offsetof(VkPhysicalDeviceProperties, deviceName) << std::endl;
        std::cout << "pipelineCacheUUID: " << offsetof(VkPhysicalDeviceProperties, pipelineCacheUUID) << std::endl;
        std::cout << "limits: " << offsetof(VkPhysicalDeviceProperties, limits) << std::endl;
        std::cout << "sparseProperties: " << offsetof(VkPhysicalDeviceProperties, sparseProperties) << std::endl;
    std::cout << std::endl;

    std::cout << "VkExtensionProperties" << std::endl;
        std::cout << "extensionName: " << offsetof(VkExtensionProperties, extensionName) << std::endl;
        std::cout << "specVersion: " << offsetof(VkExtensionProperties, specVersion) << std::endl;
    std::cout << std::endl;

    std::cout << "VkLayerProperties" << std::endl;
        std::cout << "layerName: " << offsetof(VkLayerProperties, layerName) << std::endl;
        std::cout << "specVersion: " << offsetof(VkLayerProperties, specVersion) << std::endl;
        std::cout << "implementationVersion: " << offsetof(VkLayerProperties, implementationVersion) << std::endl;
        std::cout << "description: " << offsetof(VkLayerProperties, description) << std::endl;
    std::cout << std::endl;

    std::cout << "VkApplicationInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkApplicationInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkApplicationInfo, pNext) << std::endl;
        std::cout << "pApplicationName: " << offsetof(VkApplicationInfo, pApplicationName) << std::endl;
        std::cout << "applicationVersion: " << offsetof(VkApplicationInfo, applicationVersion) << std::endl;
        std::cout << "pEngineName: " << offsetof(VkApplicationInfo, pEngineName) << std::endl;
        std::cout << "engineVersion: " << offsetof(VkApplicationInfo, engineVersion) << std::endl;
        std::cout << "apiVersion: " << offsetof(VkApplicationInfo, apiVersion) << std::endl;
    std::cout << std::endl;

    std::cout << "VkAllocationCallbacks" << std::endl;
        std::cout << "pUserData: " << offsetof(VkAllocationCallbacks, pUserData) << std::endl;
        std::cout << "pfnAllocation: " << offsetof(VkAllocationCallbacks, pfnAllocation) << std::endl;
        std::cout << "pfnReallocation: " << offsetof(VkAllocationCallbacks, pfnReallocation) << std::endl;
        std::cout << "pfnFree: " << offsetof(VkAllocationCallbacks, pfnFree) << std::endl;
        std::cout << "pfnInternalAllocation: " << offsetof(VkAllocationCallbacks, pfnInternalAllocation) << std::endl;
        std::cout << "pfnInternalFree: " << offsetof(VkAllocationCallbacks, pfnInternalFree) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDeviceQueueCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkDeviceQueueCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkDeviceQueueCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkDeviceQueueCreateInfo, flags) << std::endl;
        std::cout << "queueFamilyIndex: " << offsetof(VkDeviceQueueCreateInfo, queueFamilyIndex) << std::endl;
        std::cout << "queueCount: " << offsetof(VkDeviceQueueCreateInfo, queueCount) << std::endl;
        std::cout << "pQueuePriorities: " << offsetof(VkDeviceQueueCreateInfo, pQueuePriorities) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDeviceCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkDeviceCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkDeviceCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkDeviceCreateInfo, flags) << std::endl;
        std::cout << "queueCreateInfoCount: " << offsetof(VkDeviceCreateInfo, queueCreateInfoCount) << std::endl;
        std::cout << "pQueueCreateInfos: " << offsetof(VkDeviceCreateInfo, pQueueCreateInfos) << std::endl;
        std::cout << "enabledLayerCount: " << offsetof(VkDeviceCreateInfo, enabledLayerCount) << std::endl;
        std::cout << "ppEnabledLayerNames: " << offsetof(VkDeviceCreateInfo, ppEnabledLayerNames) << std::endl;
        std::cout << "enabledExtensionCount: " << offsetof(VkDeviceCreateInfo, enabledExtensionCount) << std::endl;
        std::cout << "ppEnabledExtensionNames: " << offsetof(VkDeviceCreateInfo, ppEnabledExtensionNames) << std::endl;
        std::cout << "pEnabledFeatures: " << offsetof(VkDeviceCreateInfo, pEnabledFeatures) << std::endl;
    std::cout << std::endl;

    std::cout << "VkInstanceCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkInstanceCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkInstanceCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkInstanceCreateInfo, flags) << std::endl;
        std::cout << "pApplicationInfo: " << offsetof(VkInstanceCreateInfo, pApplicationInfo) << std::endl;
        std::cout << "enabledLayerCount: " << offsetof(VkInstanceCreateInfo, enabledLayerCount) << std::endl;
        std::cout << "ppEnabledLayerNames: " << offsetof(VkInstanceCreateInfo, ppEnabledLayerNames) << std::endl;
        std::cout << "enabledExtensionCount: " << offsetof(VkInstanceCreateInfo, enabledExtensionCount) << std::endl;
        std::cout << "ppEnabledExtensionNames: " << offsetof(VkInstanceCreateInfo, ppEnabledExtensionNames) << std::endl;
    std::cout << std::endl;

    std::cout << "VkQueueFamilyProperties" << std::endl;
        std::cout << "queueFlags: " << offsetof(VkQueueFamilyProperties, queueFlags) << std::endl;
        std::cout << "queueCount: " << offsetof(VkQueueFamilyProperties, queueCount) << std::endl;
        std::cout << "timestampValidBits: " << offsetof(VkQueueFamilyProperties, timestampValidBits) << std::endl;
        std::cout << "minImageTransferGranularity: " << offsetof(VkQueueFamilyProperties, minImageTransferGranularity) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPhysicalDeviceMemoryProperties" << std::endl;
        std::cout << "memoryTypeCount: " << offsetof(VkPhysicalDeviceMemoryProperties, memoryTypeCount) << std::endl;
        std::cout << "memoryTypes: " << offsetof(VkPhysicalDeviceMemoryProperties, memoryTypes) << std::endl;
        std::cout << "memoryHeapCount: " << offsetof(VkPhysicalDeviceMemoryProperties, memoryHeapCount) << std::endl;
        std::cout << "memoryHeaps: " << offsetof(VkPhysicalDeviceMemoryProperties, memoryHeaps) << std::endl;
    std::cout << std::endl;

    std::cout << "VkMemoryAllocateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkMemoryAllocateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkMemoryAllocateInfo, pNext) << std::endl;
        std::cout << "allocationSize: " << offsetof(VkMemoryAllocateInfo, allocationSize) << std::endl;
        std::cout << "memoryTypeIndex: " << offsetof(VkMemoryAllocateInfo, memoryTypeIndex) << std::endl;
    std::cout << std::endl;

    std::cout << "VkMemoryRequirements" << std::endl;
        std::cout << "size: " << offsetof(VkMemoryRequirements, size) << std::endl;
        std::cout << "alignment: " << offsetof(VkMemoryRequirements, alignment) << std::endl;
        std::cout << "memoryTypeBits: " << offsetof(VkMemoryRequirements, memoryTypeBits) << std::endl;
    std::cout << std::endl;

    std::cout << "VkSparseImageFormatProperties" << std::endl;
        std::cout << "aspectMask: " << offsetof(VkSparseImageFormatProperties, aspectMask) << std::endl;
        std::cout << "imageGranularity: " << offsetof(VkSparseImageFormatProperties, imageGranularity) << std::endl;
        std::cout << "flags: " << offsetof(VkSparseImageFormatProperties, flags) << std::endl;
    std::cout << std::endl;

    std::cout << "VkSparseImageMemoryRequirements" << std::endl;
        std::cout << "formatProperties: " << offsetof(VkSparseImageMemoryRequirements, formatProperties) << std::endl;
        std::cout << "imageMipTailFirstLod: " << offsetof(VkSparseImageMemoryRequirements, imageMipTailFirstLod) << std::endl;
        std::cout << "imageMipTailSize: " << offsetof(VkSparseImageMemoryRequirements, imageMipTailSize) << std::endl;
        std::cout << "imageMipTailOffset: " << offsetof(VkSparseImageMemoryRequirements, imageMipTailOffset) << std::endl;
        std::cout << "imageMipTailStride: " << offsetof(VkSparseImageMemoryRequirements, imageMipTailStride) << std::endl;
    std::cout << std::endl;

    std::cout << "VkMemoryType" << std::endl;
        std::cout << "propertyFlags: " << offsetof(VkMemoryType, propertyFlags) << std::endl;
        std::cout << "heapIndex: " << offsetof(VkMemoryType, heapIndex) << std::endl;
    std::cout << std::endl;

    std::cout << "VkMemoryHeap" << std::endl;
        std::cout << "size: " << offsetof(VkMemoryHeap, size) << std::endl;
        std::cout << "flags: " << offsetof(VkMemoryHeap, flags) << std::endl;
    std::cout << std::endl;

    std::cout << "VkMappedMemoryRange" << std::endl;
        std::cout << "sType: " << offsetof(VkMappedMemoryRange, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkMappedMemoryRange, pNext) << std::endl;
        std::cout << "memory: " << offsetof(VkMappedMemoryRange, memory) << std::endl;
        std::cout << "offset: " << offsetof(VkMappedMemoryRange, offset) << std::endl;
        std::cout << "size: " << offsetof(VkMappedMemoryRange, size) << std::endl;
    std::cout << std::endl;

    std::cout << "VkFormatProperties" << std::endl;
        std::cout << "linearTilingFeatures: " << offsetof(VkFormatProperties, linearTilingFeatures) << std::endl;
        std::cout << "optimalTilingFeatures: " << offsetof(VkFormatProperties, optimalTilingFeatures) << std::endl;
        std::cout << "bufferFeatures: " << offsetof(VkFormatProperties, bufferFeatures) << std::endl;
    std::cout << std::endl;

    std::cout << "VkImageFormatProperties" << std::endl;
        std::cout << "maxExtent: " << offsetof(VkImageFormatProperties, maxExtent) << std::endl;
        std::cout << "maxMipLevels: " << offsetof(VkImageFormatProperties, maxMipLevels) << std::endl;
        std::cout << "maxArrayLayers: " << offsetof(VkImageFormatProperties, maxArrayLayers) << std::endl;
        std::cout << "sampleCounts: " << offsetof(VkImageFormatProperties, sampleCounts) << std::endl;
        std::cout << "maxResourceSize: " << offsetof(VkImageFormatProperties, maxResourceSize) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDescriptorBufferInfo" << std::endl;
        std::cout << "buffer: " << offsetof(VkDescriptorBufferInfo, buffer) << std::endl;
        std::cout << "offset: " << offsetof(VkDescriptorBufferInfo, offset) << std::endl;
        std::cout << "range: " << offsetof(VkDescriptorBufferInfo, range) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDescriptorImageInfo" << std::endl;
        std::cout << "sampler: " << offsetof(VkDescriptorImageInfo, sampler) << std::endl;
        std::cout << "imageView: " << offsetof(VkDescriptorImageInfo, imageView) << std::endl;
        std::cout << "imageLayout: " << offsetof(VkDescriptorImageInfo, imageLayout) << std::endl;
    std::cout << std::endl;

    std::cout << "VkWriteDescriptorSet" << std::endl;
        std::cout << "sType: " << offsetof(VkWriteDescriptorSet, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkWriteDescriptorSet, pNext) << std::endl;
        std::cout << "dstSet: " << offsetof(VkWriteDescriptorSet, dstSet) << std::endl;
        std::cout << "dstBinding: " << offsetof(VkWriteDescriptorSet, dstBinding) << std::endl;
        std::cout << "dstArrayElement: " << offsetof(VkWriteDescriptorSet, dstArrayElement) << std::endl;
        std::cout << "descriptorCount: " << offsetof(VkWriteDescriptorSet, descriptorCount) << std::endl;
        std::cout << "descriptorType: " << offsetof(VkWriteDescriptorSet, descriptorType) << std::endl;
        std::cout << "pImageInfo: " << offsetof(VkWriteDescriptorSet, pImageInfo) << std::endl;
        std::cout << "pBufferInfo: " << offsetof(VkWriteDescriptorSet, pBufferInfo) << std::endl;
        std::cout << "pTexelBufferView: " << offsetof(VkWriteDescriptorSet, pTexelBufferView) << std::endl;
    std::cout << std::endl;

    std::cout << "VkCopyDescriptorSet" << std::endl;
        std::cout << "sType: " << offsetof(VkCopyDescriptorSet, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkCopyDescriptorSet, pNext) << std::endl;
        std::cout << "srcSet: " << offsetof(VkCopyDescriptorSet, srcSet) << std::endl;
        std::cout << "srcBinding: " << offsetof(VkCopyDescriptorSet, srcBinding) << std::endl;
        std::cout << "srcArrayElement: " << offsetof(VkCopyDescriptorSet, srcArrayElement) << std::endl;
        std::cout << "dstSet: " << offsetof(VkCopyDescriptorSet, dstSet) << std::endl;
        std::cout << "dstBinding: " << offsetof(VkCopyDescriptorSet, dstBinding) << std::endl;
        std::cout << "dstArrayElement: " << offsetof(VkCopyDescriptorSet, dstArrayElement) << std::endl;
        std::cout << "descriptorCount: " << offsetof(VkCopyDescriptorSet, descriptorCount) << std::endl;
    std::cout << std::endl;

    std::cout << "VkBufferCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkBufferCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkBufferCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkBufferCreateInfo, flags) << std::endl;
        std::cout << "size: " << offsetof(VkBufferCreateInfo, size) << std::endl;
        std::cout << "usage: " << offsetof(VkBufferCreateInfo, usage) << std::endl;
        std::cout << "sharingMode: " << offsetof(VkBufferCreateInfo, sharingMode) << std::endl;
        std::cout << "queueFamilyIndexCount: " << offsetof(VkBufferCreateInfo, queueFamilyIndexCount) << std::endl;
        std::cout << "pQueueFamilyIndices: " << offsetof(VkBufferCreateInfo, pQueueFamilyIndices) << std::endl;
    std::cout << std::endl;

    std::cout << "VkBufferViewCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkBufferViewCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkBufferViewCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkBufferViewCreateInfo, flags) << std::endl;
        std::cout << "buffer: " << offsetof(VkBufferViewCreateInfo, buffer) << std::endl;
        std::cout << "format: " << offsetof(VkBufferViewCreateInfo, format) << std::endl;
        std::cout << "offset: " << offsetof(VkBufferViewCreateInfo, offset) << std::endl;
        std::cout << "range: " << offsetof(VkBufferViewCreateInfo, range) << std::endl;
    std::cout << std::endl;

    std::cout << "VkImageSubresource" << std::endl;
        std::cout << "aspectMask: " << offsetof(VkImageSubresource, aspectMask) << std::endl;
        std::cout << "mipLevel: " << offsetof(VkImageSubresource, mipLevel) << std::endl;
        std::cout << "arrayLayer: " << offsetof(VkImageSubresource, arrayLayer) << std::endl;
    std::cout << std::endl;

    std::cout << "VkImageSubresourceLayers" << std::endl;
        std::cout << "aspectMask: " << offsetof(VkImageSubresourceLayers, aspectMask) << std::endl;
        std::cout << "mipLevel: " << offsetof(VkImageSubresourceLayers, mipLevel) << std::endl;
        std::cout << "baseArrayLayer: " << offsetof(VkImageSubresourceLayers, baseArrayLayer) << std::endl;
        std::cout << "layerCount: " << offsetof(VkImageSubresourceLayers, layerCount) << std::endl;
    std::cout << std::endl;

    std::cout << "VkImageSubresourceRange" << std::endl;
        std::cout << "aspectMask: " << offsetof(VkImageSubresourceRange, aspectMask) << std::endl;
        std::cout << "baseMipLevel: " << offsetof(VkImageSubresourceRange, baseMipLevel) << std::endl;
        std::cout << "levelCount: " << offsetof(VkImageSubresourceRange, levelCount) << std::endl;
        std::cout << "baseArrayLayer: " << offsetof(VkImageSubresourceRange, baseArrayLayer) << std::endl;
        std::cout << "layerCount: " << offsetof(VkImageSubresourceRange, layerCount) << std::endl;
    std::cout << std::endl;

    std::cout << "VkMemoryBarrier" << std::endl;
        std::cout << "sType: " << offsetof(VkMemoryBarrier, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkMemoryBarrier, pNext) << std::endl;
        std::cout << "srcAccessMask: " << offsetof(VkMemoryBarrier, srcAccessMask) << std::endl;
        std::cout << "dstAccessMask: " << offsetof(VkMemoryBarrier, dstAccessMask) << std::endl;
    std::cout << std::endl;

    std::cout << "VkBufferMemoryBarrier" << std::endl;
        std::cout << "sType: " << offsetof(VkBufferMemoryBarrier, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkBufferMemoryBarrier, pNext) << std::endl;
        std::cout << "srcAccessMask: " << offsetof(VkBufferMemoryBarrier, srcAccessMask) << std::endl;
        std::cout << "dstAccessMask: " << offsetof(VkBufferMemoryBarrier, dstAccessMask) << std::endl;
        std::cout << "srcQueueFamilyIndex: " << offsetof(VkBufferMemoryBarrier, srcQueueFamilyIndex) << std::endl;
        std::cout << "dstQueueFamilyIndex: " << offsetof(VkBufferMemoryBarrier, dstQueueFamilyIndex) << std::endl;
        std::cout << "buffer: " << offsetof(VkBufferMemoryBarrier, buffer) << std::endl;
        std::cout << "offset: " << offsetof(VkBufferMemoryBarrier, offset) << std::endl;
        std::cout << "size: " << offsetof(VkBufferMemoryBarrier, size) << std::endl;
    std::cout << std::endl;

    std::cout << "VkImageMemoryBarrier" << std::endl;
        std::cout << "sType: " << offsetof(VkImageMemoryBarrier, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkImageMemoryBarrier, pNext) << std::endl;
        std::cout << "srcAccessMask: " << offsetof(VkImageMemoryBarrier, srcAccessMask) << std::endl;
        std::cout << "dstAccessMask: " << offsetof(VkImageMemoryBarrier, dstAccessMask) << std::endl;
        std::cout << "oldLayout: " << offsetof(VkImageMemoryBarrier, oldLayout) << std::endl;
        std::cout << "newLayout: " << offsetof(VkImageMemoryBarrier, newLayout) << std::endl;
        std::cout << "srcQueueFamilyIndex: " << offsetof(VkImageMemoryBarrier, srcQueueFamilyIndex) << std::endl;
        std::cout << "dstQueueFamilyIndex: " << offsetof(VkImageMemoryBarrier, dstQueueFamilyIndex) << std::endl;
        std::cout << "image: " << offsetof(VkImageMemoryBarrier, image) << std::endl;
        std::cout << "subresourceRange: " << offsetof(VkImageMemoryBarrier, subresourceRange) << std::endl;
    std::cout << std::endl;

    std::cout << "VkImageCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkImageCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkImageCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkImageCreateInfo, flags) << std::endl;
        std::cout << "imageType: " << offsetof(VkImageCreateInfo, imageType) << std::endl;
        std::cout << "format: " << offsetof(VkImageCreateInfo, format) << std::endl;
        std::cout << "extent: " << offsetof(VkImageCreateInfo, extent) << std::endl;
        std::cout << "mipLevels: " << offsetof(VkImageCreateInfo, mipLevels) << std::endl;
        std::cout << "arrayLayers: " << offsetof(VkImageCreateInfo, arrayLayers) << std::endl;
        std::cout << "samples: " << offsetof(VkImageCreateInfo, samples) << std::endl;
        std::cout << "tiling: " << offsetof(VkImageCreateInfo, tiling) << std::endl;
        std::cout << "usage: " << offsetof(VkImageCreateInfo, usage) << std::endl;
        std::cout << "sharingMode: " << offsetof(VkImageCreateInfo, sharingMode) << std::endl;
        std::cout << "queueFamilyIndexCount: " << offsetof(VkImageCreateInfo, queueFamilyIndexCount) << std::endl;
        std::cout << "pQueueFamilyIndices: " << offsetof(VkImageCreateInfo, pQueueFamilyIndices) << std::endl;
        std::cout << "initialLayout: " << offsetof(VkImageCreateInfo, initialLayout) << std::endl;
    std::cout << std::endl;

    std::cout << "VkSubresourceLayout" << std::endl;
        std::cout << "offset: " << offsetof(VkSubresourceLayout, offset) << std::endl;
        std::cout << "size: " << offsetof(VkSubresourceLayout, size) << std::endl;
        std::cout << "rowPitch: " << offsetof(VkSubresourceLayout, rowPitch) << std::endl;
        std::cout << "arrayPitch: " << offsetof(VkSubresourceLayout, arrayPitch) << std::endl;
        std::cout << "depthPitch: " << offsetof(VkSubresourceLayout, depthPitch) << std::endl;
    std::cout << std::endl;

    std::cout << "VkImageViewCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkImageViewCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkImageViewCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkImageViewCreateInfo, flags) << std::endl;
        std::cout << "image: " << offsetof(VkImageViewCreateInfo, image) << std::endl;
        std::cout << "viewType: " << offsetof(VkImageViewCreateInfo, viewType) << std::endl;
        std::cout << "format: " << offsetof(VkImageViewCreateInfo, format) << std::endl;
        std::cout << "components: " << offsetof(VkImageViewCreateInfo, components) << std::endl;
        std::cout << "subresourceRange: " << offsetof(VkImageViewCreateInfo, subresourceRange) << std::endl;
    std::cout << std::endl;

    std::cout << "VkBufferCopy" << std::endl;
        std::cout << "srcOffset: " << offsetof(VkBufferCopy, srcOffset) << std::endl;
        std::cout << "dstOffset: " << offsetof(VkBufferCopy, dstOffset) << std::endl;
        std::cout << "size: " << offsetof(VkBufferCopy, size) << std::endl;
    std::cout << std::endl;

    std::cout << "VkSparseMemoryBind" << std::endl;
        std::cout << "resourceOffset: " << offsetof(VkSparseMemoryBind, resourceOffset) << std::endl;
        std::cout << "size: " << offsetof(VkSparseMemoryBind, size) << std::endl;
        std::cout << "memory: " << offsetof(VkSparseMemoryBind, memory) << std::endl;
        std::cout << "memoryOffset: " << offsetof(VkSparseMemoryBind, memoryOffset) << std::endl;
        std::cout << "flags: " << offsetof(VkSparseMemoryBind, flags) << std::endl;
    std::cout << std::endl;

    std::cout << "VkSparseImageMemoryBind" << std::endl;
        std::cout << "subresource: " << offsetof(VkSparseImageMemoryBind, subresource) << std::endl;
        std::cout << "offset: " << offsetof(VkSparseImageMemoryBind, offset) << std::endl;
        std::cout << "extent: " << offsetof(VkSparseImageMemoryBind, extent) << std::endl;
        std::cout << "memory: " << offsetof(VkSparseImageMemoryBind, memory) << std::endl;
        std::cout << "memoryOffset: " << offsetof(VkSparseImageMemoryBind, memoryOffset) << std::endl;
        std::cout << "flags: " << offsetof(VkSparseImageMemoryBind, flags) << std::endl;
    std::cout << std::endl;

    std::cout << "VkSparseBufferMemoryBindInfo" << std::endl;
        std::cout << "buffer: " << offsetof(VkSparseBufferMemoryBindInfo, buffer) << std::endl;
        std::cout << "bindCount: " << offsetof(VkSparseBufferMemoryBindInfo, bindCount) << std::endl;
        std::cout << "pBinds: " << offsetof(VkSparseBufferMemoryBindInfo, pBinds) << std::endl;
    std::cout << std::endl;

    std::cout << "VkSparseImageOpaqueMemoryBindInfo" << std::endl;
        std::cout << "image: " << offsetof(VkSparseImageOpaqueMemoryBindInfo, image) << std::endl;
        std::cout << "bindCount: " << offsetof(VkSparseImageOpaqueMemoryBindInfo, bindCount) << std::endl;
        std::cout << "pBinds: " << offsetof(VkSparseImageOpaqueMemoryBindInfo, pBinds) << std::endl;
    std::cout << std::endl;

    std::cout << "VkSparseImageMemoryBindInfo" << std::endl;
        std::cout << "image: " << offsetof(VkSparseImageMemoryBindInfo, image) << std::endl;
        std::cout << "bindCount: " << offsetof(VkSparseImageMemoryBindInfo, bindCount) << std::endl;
        std::cout << "pBinds: " << offsetof(VkSparseImageMemoryBindInfo, pBinds) << std::endl;
    std::cout << std::endl;

    std::cout << "VkBindSparseInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkBindSparseInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkBindSparseInfo, pNext) << std::endl;
        std::cout << "waitSemaphoreCount: " << offsetof(VkBindSparseInfo, waitSemaphoreCount) << std::endl;
        std::cout << "pWaitSemaphores: " << offsetof(VkBindSparseInfo, pWaitSemaphores) << std::endl;
        std::cout << "bufferBindCount: " << offsetof(VkBindSparseInfo, bufferBindCount) << std::endl;
        std::cout << "pBufferBinds: " << offsetof(VkBindSparseInfo, pBufferBinds) << std::endl;
        std::cout << "imageOpaqueBindCount: " << offsetof(VkBindSparseInfo, imageOpaqueBindCount) << std::endl;
        std::cout << "pImageOpaqueBinds: " << offsetof(VkBindSparseInfo, pImageOpaqueBinds) << std::endl;
        std::cout << "imageBindCount: " << offsetof(VkBindSparseInfo, imageBindCount) << std::endl;
        std::cout << "pImageBinds: " << offsetof(VkBindSparseInfo, pImageBinds) << std::endl;
        std::cout << "signalSemaphoreCount: " << offsetof(VkBindSparseInfo, signalSemaphoreCount) << std::endl;
        std::cout << "pSignalSemaphores: " << offsetof(VkBindSparseInfo, pSignalSemaphores) << std::endl;
    std::cout << std::endl;

    std::cout << "VkImageCopy" << std::endl;
        std::cout << "srcSubresource: " << offsetof(VkImageCopy, srcSubresource) << std::endl;
        std::cout << "srcOffset: " << offsetof(VkImageCopy, srcOffset) << std::endl;
        std::cout << "dstSubresource: " << offsetof(VkImageCopy, dstSubresource) << std::endl;
        std::cout << "dstOffset: " << offsetof(VkImageCopy, dstOffset) << std::endl;
        std::cout << "extent: " << offsetof(VkImageCopy, extent) << std::endl;
    std::cout << std::endl;

    std::cout << "VkImageBlit" << std::endl;
        std::cout << "srcSubresource: " << offsetof(VkImageBlit, srcSubresource) << std::endl;
        std::cout << "srcOffsets: " << offsetof(VkImageBlit, srcOffsets) << std::endl;
        std::cout << "dstSubresource: " << offsetof(VkImageBlit, dstSubresource) << std::endl;
        std::cout << "dstOffsets: " << offsetof(VkImageBlit, dstOffsets) << std::endl;
    std::cout << std::endl;

    std::cout << "VkBufferImageCopy" << std::endl;
        std::cout << "bufferOffset: " << offsetof(VkBufferImageCopy, bufferOffset) << std::endl;
        std::cout << "bufferRowLength: " << offsetof(VkBufferImageCopy, bufferRowLength) << std::endl;
        std::cout << "bufferImageHeight: " << offsetof(VkBufferImageCopy, bufferImageHeight) << std::endl;
        std::cout << "imageSubresource: " << offsetof(VkBufferImageCopy, imageSubresource) << std::endl;
        std::cout << "imageOffset: " << offsetof(VkBufferImageCopy, imageOffset) << std::endl;
        std::cout << "imageExtent: " << offsetof(VkBufferImageCopy, imageExtent) << std::endl;
    std::cout << std::endl;

    std::cout << "VkImageResolve" << std::endl;
        std::cout << "srcSubresource: " << offsetof(VkImageResolve, srcSubresource) << std::endl;
        std::cout << "srcOffset: " << offsetof(VkImageResolve, srcOffset) << std::endl;
        std::cout << "dstSubresource: " << offsetof(VkImageResolve, dstSubresource) << std::endl;
        std::cout << "dstOffset: " << offsetof(VkImageResolve, dstOffset) << std::endl;
        std::cout << "extent: " << offsetof(VkImageResolve, extent) << std::endl;
    std::cout << std::endl;

    std::cout << "VkShaderModuleCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkShaderModuleCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkShaderModuleCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkShaderModuleCreateInfo, flags) << std::endl;
        std::cout << "codeSize: " << offsetof(VkShaderModuleCreateInfo, codeSize) << std::endl;
        std::cout << "pCode: " << offsetof(VkShaderModuleCreateInfo, pCode) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDescriptorSetLayoutBinding" << std::endl;
        std::cout << "binding: " << offsetof(VkDescriptorSetLayoutBinding, binding) << std::endl;
        std::cout << "descriptorType: " << offsetof(VkDescriptorSetLayoutBinding, descriptorType) << std::endl;
        std::cout << "descriptorCount: " << offsetof(VkDescriptorSetLayoutBinding, descriptorCount) << std::endl;
        std::cout << "stageFlags: " << offsetof(VkDescriptorSetLayoutBinding, stageFlags) << std::endl;
        std::cout << "pImmutableSamplers: " << offsetof(VkDescriptorSetLayoutBinding, pImmutableSamplers) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDescriptorSetLayoutCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkDescriptorSetLayoutCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkDescriptorSetLayoutCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkDescriptorSetLayoutCreateInfo, flags) << std::endl;
        std::cout << "bindingCount: " << offsetof(VkDescriptorSetLayoutCreateInfo, bindingCount) << std::endl;
        std::cout << "pBindings: " << offsetof(VkDescriptorSetLayoutCreateInfo, pBindings) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDescriptorPoolSize" << std::endl;
        std::cout << "type: " << offsetof(VkDescriptorPoolSize, type) << std::endl;
        std::cout << "descriptorCount: " << offsetof(VkDescriptorPoolSize, descriptorCount) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDescriptorPoolCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkDescriptorPoolCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkDescriptorPoolCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkDescriptorPoolCreateInfo, flags) << std::endl;
        std::cout << "maxSets: " << offsetof(VkDescriptorPoolCreateInfo, maxSets) << std::endl;
        std::cout << "poolSizeCount: " << offsetof(VkDescriptorPoolCreateInfo, poolSizeCount) << std::endl;
        std::cout << "pPoolSizes: " << offsetof(VkDescriptorPoolCreateInfo, pPoolSizes) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDescriptorSetAllocateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkDescriptorSetAllocateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkDescriptorSetAllocateInfo, pNext) << std::endl;
        std::cout << "descriptorPool: " << offsetof(VkDescriptorSetAllocateInfo, descriptorPool) << std::endl;
        std::cout << "descriptorSetCount: " << offsetof(VkDescriptorSetAllocateInfo, descriptorSetCount) << std::endl;
        std::cout << "pSetLayouts: " << offsetof(VkDescriptorSetAllocateInfo, pSetLayouts) << std::endl;
    std::cout << std::endl;

    std::cout << "VkSpecializationMapEntry" << std::endl;
        std::cout << "constantID: " << offsetof(VkSpecializationMapEntry, constantID) << std::endl;
        std::cout << "offset: " << offsetof(VkSpecializationMapEntry, offset) << std::endl;
        std::cout << "size: " << offsetof(VkSpecializationMapEntry, size) << std::endl;
    std::cout << std::endl;

    std::cout << "VkSpecializationInfo" << std::endl;
        std::cout << "mapEntryCount: " << offsetof(VkSpecializationInfo, mapEntryCount) << std::endl;
        std::cout << "pMapEntries: " << offsetof(VkSpecializationInfo, pMapEntries) << std::endl;
        std::cout << "dataSize: " << offsetof(VkSpecializationInfo, dataSize) << std::endl;
        std::cout << "pData: " << offsetof(VkSpecializationInfo, pData) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPipelineShaderStageCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkPipelineShaderStageCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkPipelineShaderStageCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkPipelineShaderStageCreateInfo, flags) << std::endl;
        std::cout << "stage: " << offsetof(VkPipelineShaderStageCreateInfo, stage) << std::endl;
        std::cout << "module: " << offsetof(VkPipelineShaderStageCreateInfo, module) << std::endl;
        std::cout << "pName: " << offsetof(VkPipelineShaderStageCreateInfo, pName) << std::endl;
        std::cout << "pSpecializationInfo: " << offsetof(VkPipelineShaderStageCreateInfo, pSpecializationInfo) << std::endl;
    std::cout << std::endl;

    std::cout << "VkComputePipelineCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkComputePipelineCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkComputePipelineCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkComputePipelineCreateInfo, flags) << std::endl;
        std::cout << "stage: " << offsetof(VkComputePipelineCreateInfo, stage) << std::endl;
        std::cout << "layout: " << offsetof(VkComputePipelineCreateInfo, layout) << std::endl;
        std::cout << "basePipelineHandle: " << offsetof(VkComputePipelineCreateInfo, basePipelineHandle) << std::endl;
        std::cout << "basePipelineIndex: " << offsetof(VkComputePipelineCreateInfo, basePipelineIndex) << std::endl;
    std::cout << std::endl;

    std::cout << "VkVertexInputBindingDescription" << std::endl;
        std::cout << "binding: " << offsetof(VkVertexInputBindingDescription, binding) << std::endl;
        std::cout << "stride: " << offsetof(VkVertexInputBindingDescription, stride) << std::endl;
        std::cout << "inputRate: " << offsetof(VkVertexInputBindingDescription, inputRate) << std::endl;
    std::cout << std::endl;

    std::cout << "VkVertexInputAttributeDescription" << std::endl;
        std::cout << "location: " << offsetof(VkVertexInputAttributeDescription, location) << std::endl;
        std::cout << "binding: " << offsetof(VkVertexInputAttributeDescription, binding) << std::endl;
        std::cout << "format: " << offsetof(VkVertexInputAttributeDescription, format) << std::endl;
        std::cout << "offset: " << offsetof(VkVertexInputAttributeDescription, offset) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPipelineVertexInputStateCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkPipelineVertexInputStateCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkPipelineVertexInputStateCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkPipelineVertexInputStateCreateInfo, flags) << std::endl;
        std::cout << "vertexBindingDescriptionCount: " << offsetof(VkPipelineVertexInputStateCreateInfo, vertexBindingDescriptionCount) << std::endl;
        std::cout << "pVertexBindingDescriptions: " << offsetof(VkPipelineVertexInputStateCreateInfo, pVertexBindingDescriptions) << std::endl;
        std::cout << "vertexAttributeDescriptionCount: " << offsetof(VkPipelineVertexInputStateCreateInfo, vertexAttributeDescriptionCount) << std::endl;
        std::cout << "pVertexAttributeDescriptions: " << offsetof(VkPipelineVertexInputStateCreateInfo, pVertexAttributeDescriptions) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPipelineInputAssemblyStateCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkPipelineInputAssemblyStateCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkPipelineInputAssemblyStateCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkPipelineInputAssemblyStateCreateInfo, flags) << std::endl;
        std::cout << "topology: " << offsetof(VkPipelineInputAssemblyStateCreateInfo, topology) << std::endl;
        std::cout << "primitiveRestartEnable: " << offsetof(VkPipelineInputAssemblyStateCreateInfo, primitiveRestartEnable) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPipelineTessellationStateCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkPipelineTessellationStateCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkPipelineTessellationStateCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkPipelineTessellationStateCreateInfo, flags) << std::endl;
        std::cout << "patchControlPoints: " << offsetof(VkPipelineTessellationStateCreateInfo, patchControlPoints) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPipelineViewportStateCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkPipelineViewportStateCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkPipelineViewportStateCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkPipelineViewportStateCreateInfo, flags) << std::endl;
        std::cout << "viewportCount: " << offsetof(VkPipelineViewportStateCreateInfo, viewportCount) << std::endl;
        std::cout << "pViewports: " << offsetof(VkPipelineViewportStateCreateInfo, pViewports) << std::endl;
        std::cout << "scissorCount: " << offsetof(VkPipelineViewportStateCreateInfo, scissorCount) << std::endl;
        std::cout << "pScissors: " << offsetof(VkPipelineViewportStateCreateInfo, pScissors) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPipelineRasterizationStateCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkPipelineRasterizationStateCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkPipelineRasterizationStateCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkPipelineRasterizationStateCreateInfo, flags) << std::endl;
        std::cout << "depthClampEnable: " << offsetof(VkPipelineRasterizationStateCreateInfo, depthClampEnable) << std::endl;
        std::cout << "rasterizerDiscardEnable: " << offsetof(VkPipelineRasterizationStateCreateInfo, rasterizerDiscardEnable) << std::endl;
        std::cout << "polygonMode: " << offsetof(VkPipelineRasterizationStateCreateInfo, polygonMode) << std::endl;
        std::cout << "cullMode: " << offsetof(VkPipelineRasterizationStateCreateInfo, cullMode) << std::endl;
        std::cout << "frontFace: " << offsetof(VkPipelineRasterizationStateCreateInfo, frontFace) << std::endl;
        std::cout << "depthBiasEnable: " << offsetof(VkPipelineRasterizationStateCreateInfo, depthBiasEnable) << std::endl;
        std::cout << "depthBiasConstantFactor: " << offsetof(VkPipelineRasterizationStateCreateInfo, depthBiasConstantFactor) << std::endl;
        std::cout << "depthBiasClamp: " << offsetof(VkPipelineRasterizationStateCreateInfo, depthBiasClamp) << std::endl;
        std::cout << "depthBiasSlopeFactor: " << offsetof(VkPipelineRasterizationStateCreateInfo, depthBiasSlopeFactor) << std::endl;
        std::cout << "lineWidth: " << offsetof(VkPipelineRasterizationStateCreateInfo, lineWidth) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPipelineMultisampleStateCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkPipelineMultisampleStateCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkPipelineMultisampleStateCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkPipelineMultisampleStateCreateInfo, flags) << std::endl;
        std::cout << "rasterizationSamples: " << offsetof(VkPipelineMultisampleStateCreateInfo, rasterizationSamples) << std::endl;
        std::cout << "sampleShadingEnable: " << offsetof(VkPipelineMultisampleStateCreateInfo, sampleShadingEnable) << std::endl;
        std::cout << "minSampleShading: " << offsetof(VkPipelineMultisampleStateCreateInfo, minSampleShading) << std::endl;
        std::cout << "pSampleMask: " << offsetof(VkPipelineMultisampleStateCreateInfo, pSampleMask) << std::endl;
        std::cout << "alphaToCoverageEnable: " << offsetof(VkPipelineMultisampleStateCreateInfo, alphaToCoverageEnable) << std::endl;
        std::cout << "alphaToOneEnable: " << offsetof(VkPipelineMultisampleStateCreateInfo, alphaToOneEnable) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPipelineColorBlendAttachmentState" << std::endl;
        std::cout << "blendEnable: " << offsetof(VkPipelineColorBlendAttachmentState, blendEnable) << std::endl;
        std::cout << "srcColorBlendFactor: " << offsetof(VkPipelineColorBlendAttachmentState, srcColorBlendFactor) << std::endl;
        std::cout << "dstColorBlendFactor: " << offsetof(VkPipelineColorBlendAttachmentState, dstColorBlendFactor) << std::endl;
        std::cout << "colorBlendOp: " << offsetof(VkPipelineColorBlendAttachmentState, colorBlendOp) << std::endl;
        std::cout << "srcAlphaBlendFactor: " << offsetof(VkPipelineColorBlendAttachmentState, srcAlphaBlendFactor) << std::endl;
        std::cout << "dstAlphaBlendFactor: " << offsetof(VkPipelineColorBlendAttachmentState, dstAlphaBlendFactor) << std::endl;
        std::cout << "alphaBlendOp: " << offsetof(VkPipelineColorBlendAttachmentState, alphaBlendOp) << std::endl;
        std::cout << "colorWriteMask: " << offsetof(VkPipelineColorBlendAttachmentState, colorWriteMask) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPipelineColorBlendStateCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkPipelineColorBlendStateCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkPipelineColorBlendStateCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkPipelineColorBlendStateCreateInfo, flags) << std::endl;
        std::cout << "logicOpEnable: " << offsetof(VkPipelineColorBlendStateCreateInfo, logicOpEnable) << std::endl;
        std::cout << "logicOp: " << offsetof(VkPipelineColorBlendStateCreateInfo, logicOp) << std::endl;
        std::cout << "attachmentCount: " << offsetof(VkPipelineColorBlendStateCreateInfo, attachmentCount) << std::endl;
        std::cout << "pAttachments: " << offsetof(VkPipelineColorBlendStateCreateInfo, pAttachments) << std::endl;
        std::cout << "blendConstants: " << offsetof(VkPipelineColorBlendStateCreateInfo, blendConstants) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPipelineDynamicStateCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkPipelineDynamicStateCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkPipelineDynamicStateCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkPipelineDynamicStateCreateInfo, flags) << std::endl;
        std::cout << "dynamicStateCount: " << offsetof(VkPipelineDynamicStateCreateInfo, dynamicStateCount) << std::endl;
        std::cout << "pDynamicStates: " << offsetof(VkPipelineDynamicStateCreateInfo, pDynamicStates) << std::endl;
    std::cout << std::endl;

    std::cout << "VkStencilOpState" << std::endl;
        std::cout << "failOp: " << offsetof(VkStencilOpState, failOp) << std::endl;
        std::cout << "passOp: " << offsetof(VkStencilOpState, passOp) << std::endl;
        std::cout << "depthFailOp: " << offsetof(VkStencilOpState, depthFailOp) << std::endl;
        std::cout << "compareOp: " << offsetof(VkStencilOpState, compareOp) << std::endl;
        std::cout << "compareMask: " << offsetof(VkStencilOpState, compareMask) << std::endl;
        std::cout << "writeMask: " << offsetof(VkStencilOpState, writeMask) << std::endl;
        std::cout << "reference: " << offsetof(VkStencilOpState, reference) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPipelineDepthStencilStateCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkPipelineDepthStencilStateCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkPipelineDepthStencilStateCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkPipelineDepthStencilStateCreateInfo, flags) << std::endl;
        std::cout << "depthTestEnable: " << offsetof(VkPipelineDepthStencilStateCreateInfo, depthTestEnable) << std::endl;
        std::cout << "depthWriteEnable: " << offsetof(VkPipelineDepthStencilStateCreateInfo, depthWriteEnable) << std::endl;
        std::cout << "depthCompareOp: " << offsetof(VkPipelineDepthStencilStateCreateInfo, depthCompareOp) << std::endl;
        std::cout << "depthBoundsTestEnable: " << offsetof(VkPipelineDepthStencilStateCreateInfo, depthBoundsTestEnable) << std::endl;
        std::cout << "stencilTestEnable: " << offsetof(VkPipelineDepthStencilStateCreateInfo, stencilTestEnable) << std::endl;
        std::cout << "front: " << offsetof(VkPipelineDepthStencilStateCreateInfo, front) << std::endl;
        std::cout << "back: " << offsetof(VkPipelineDepthStencilStateCreateInfo, back) << std::endl;
        std::cout << "minDepthBounds: " << offsetof(VkPipelineDepthStencilStateCreateInfo, minDepthBounds) << std::endl;
        std::cout << "maxDepthBounds: " << offsetof(VkPipelineDepthStencilStateCreateInfo, maxDepthBounds) << std::endl;
    std::cout << std::endl;

    std::cout << "VkGraphicsPipelineCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkGraphicsPipelineCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkGraphicsPipelineCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkGraphicsPipelineCreateInfo, flags) << std::endl;
        std::cout << "stageCount: " << offsetof(VkGraphicsPipelineCreateInfo, stageCount) << std::endl;
        std::cout << "pStages: " << offsetof(VkGraphicsPipelineCreateInfo, pStages) << std::endl;
        std::cout << "pVertexInputState: " << offsetof(VkGraphicsPipelineCreateInfo, pVertexInputState) << std::endl;
        std::cout << "pInputAssemblyState: " << offsetof(VkGraphicsPipelineCreateInfo, pInputAssemblyState) << std::endl;
        std::cout << "pTessellationState: " << offsetof(VkGraphicsPipelineCreateInfo, pTessellationState) << std::endl;
        std::cout << "pViewportState: " << offsetof(VkGraphicsPipelineCreateInfo, pViewportState) << std::endl;
        std::cout << "pRasterizationState: " << offsetof(VkGraphicsPipelineCreateInfo, pRasterizationState) << std::endl;
        std::cout << "pMultisampleState: " << offsetof(VkGraphicsPipelineCreateInfo, pMultisampleState) << std::endl;
        std::cout << "pDepthStencilState: " << offsetof(VkGraphicsPipelineCreateInfo, pDepthStencilState) << std::endl;
        std::cout << "pColorBlendState: " << offsetof(VkGraphicsPipelineCreateInfo, pColorBlendState) << std::endl;
        std::cout << "pDynamicState: " << offsetof(VkGraphicsPipelineCreateInfo, pDynamicState) << std::endl;
        std::cout << "layout: " << offsetof(VkGraphicsPipelineCreateInfo, layout) << std::endl;
        std::cout << "renderPass: " << offsetof(VkGraphicsPipelineCreateInfo, renderPass) << std::endl;
        std::cout << "subpass: " << offsetof(VkGraphicsPipelineCreateInfo, subpass) << std::endl;
        std::cout << "basePipelineHandle: " << offsetof(VkGraphicsPipelineCreateInfo, basePipelineHandle) << std::endl;
        std::cout << "basePipelineIndex: " << offsetof(VkGraphicsPipelineCreateInfo, basePipelineIndex) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPipelineCacheCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkPipelineCacheCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkPipelineCacheCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkPipelineCacheCreateInfo, flags) << std::endl;
        std::cout << "initialDataSize: " << offsetof(VkPipelineCacheCreateInfo, initialDataSize) << std::endl;
        std::cout << "pInitialData: " << offsetof(VkPipelineCacheCreateInfo, pInitialData) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPushConstantRange" << std::endl;
        std::cout << "stageFlags: " << offsetof(VkPushConstantRange, stageFlags) << std::endl;
        std::cout << "offset: " << offsetof(VkPushConstantRange, offset) << std::endl;
        std::cout << "size: " << offsetof(VkPushConstantRange, size) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPipelineLayoutCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkPipelineLayoutCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkPipelineLayoutCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkPipelineLayoutCreateInfo, flags) << std::endl;
        std::cout << "setLayoutCount: " << offsetof(VkPipelineLayoutCreateInfo, setLayoutCount) << std::endl;
        std::cout << "pSetLayouts: " << offsetof(VkPipelineLayoutCreateInfo, pSetLayouts) << std::endl;
        std::cout << "pushConstantRangeCount: " << offsetof(VkPipelineLayoutCreateInfo, pushConstantRangeCount) << std::endl;
        std::cout << "pPushConstantRanges: " << offsetof(VkPipelineLayoutCreateInfo, pPushConstantRanges) << std::endl;
    std::cout << std::endl;

    std::cout << "VkSamplerCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkSamplerCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkSamplerCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkSamplerCreateInfo, flags) << std::endl;
        std::cout << "magFilter: " << offsetof(VkSamplerCreateInfo, magFilter) << std::endl;
        std::cout << "minFilter: " << offsetof(VkSamplerCreateInfo, minFilter) << std::endl;
        std::cout << "mipmapMode: " << offsetof(VkSamplerCreateInfo, mipmapMode) << std::endl;
        std::cout << "addressModeU: " << offsetof(VkSamplerCreateInfo, addressModeU) << std::endl;
        std::cout << "addressModeV: " << offsetof(VkSamplerCreateInfo, addressModeV) << std::endl;
        std::cout << "addressModeW: " << offsetof(VkSamplerCreateInfo, addressModeW) << std::endl;
        std::cout << "mipLodBias: " << offsetof(VkSamplerCreateInfo, mipLodBias) << std::endl;
        std::cout << "anisotropyEnable: " << offsetof(VkSamplerCreateInfo, anisotropyEnable) << std::endl;
        std::cout << "maxAnisotropy: " << offsetof(VkSamplerCreateInfo, maxAnisotropy) << std::endl;
        std::cout << "compareEnable: " << offsetof(VkSamplerCreateInfo, compareEnable) << std::endl;
        std::cout << "compareOp: " << offsetof(VkSamplerCreateInfo, compareOp) << std::endl;
        std::cout << "minLod: " << offsetof(VkSamplerCreateInfo, minLod) << std::endl;
        std::cout << "maxLod: " << offsetof(VkSamplerCreateInfo, maxLod) << std::endl;
        std::cout << "borderColor: " << offsetof(VkSamplerCreateInfo, borderColor) << std::endl;
        std::cout << "unnormalizedCoordinates: " << offsetof(VkSamplerCreateInfo, unnormalizedCoordinates) << std::endl;
    std::cout << std::endl;

    std::cout << "VkCommandPoolCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkCommandPoolCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkCommandPoolCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkCommandPoolCreateInfo, flags) << std::endl;
        std::cout << "queueFamilyIndex: " << offsetof(VkCommandPoolCreateInfo, queueFamilyIndex) << std::endl;
    std::cout << std::endl;

    std::cout << "VkCommandBufferAllocateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkCommandBufferAllocateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkCommandBufferAllocateInfo, pNext) << std::endl;
        std::cout << "commandPool: " << offsetof(VkCommandBufferAllocateInfo, commandPool) << std::endl;
        std::cout << "level: " << offsetof(VkCommandBufferAllocateInfo, level) << std::endl;
        std::cout << "commandBufferCount: " << offsetof(VkCommandBufferAllocateInfo, commandBufferCount) << std::endl;
    std::cout << std::endl;

    std::cout << "VkCommandBufferInheritanceInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkCommandBufferInheritanceInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkCommandBufferInheritanceInfo, pNext) << std::endl;
        std::cout << "renderPass: " << offsetof(VkCommandBufferInheritanceInfo, renderPass) << std::endl;
        std::cout << "subpass: " << offsetof(VkCommandBufferInheritanceInfo, subpass) << std::endl;
        std::cout << "framebuffer: " << offsetof(VkCommandBufferInheritanceInfo, framebuffer) << std::endl;
        std::cout << "occlusionQueryEnable: " << offsetof(VkCommandBufferInheritanceInfo, occlusionQueryEnable) << std::endl;
        std::cout << "queryFlags: " << offsetof(VkCommandBufferInheritanceInfo, queryFlags) << std::endl;
        std::cout << "pipelineStatistics: " << offsetof(VkCommandBufferInheritanceInfo, pipelineStatistics) << std::endl;
    std::cout << std::endl;

    std::cout << "VkCommandBufferBeginInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkCommandBufferBeginInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkCommandBufferBeginInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkCommandBufferBeginInfo, flags) << std::endl;
        std::cout << "pInheritanceInfo: " << offsetof(VkCommandBufferBeginInfo, pInheritanceInfo) << std::endl;
    std::cout << std::endl;

    std::cout << "VkRenderPassBeginInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkRenderPassBeginInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkRenderPassBeginInfo, pNext) << std::endl;
        std::cout << "renderPass: " << offsetof(VkRenderPassBeginInfo, renderPass) << std::endl;
        std::cout << "framebuffer: " << offsetof(VkRenderPassBeginInfo, framebuffer) << std::endl;
        std::cout << "renderArea: " << offsetof(VkRenderPassBeginInfo, renderArea) << std::endl;
        std::cout << "clearValueCount: " << offsetof(VkRenderPassBeginInfo, clearValueCount) << std::endl;
        std::cout << "pClearValues: " << offsetof(VkRenderPassBeginInfo, pClearValues) << std::endl;
    std::cout << std::endl;

    std::cout << "VkClearColorValue" << std::endl;
        std::cout << "float32: " << offsetof(VkClearColorValue, float32) << std::endl;
        std::cout << "int32: " << offsetof(VkClearColorValue, int32) << std::endl;
        std::cout << "uint32: " << offsetof(VkClearColorValue, uint32) << std::endl;
    std::cout << std::endl;

    std::cout << "VkClearDepthStencilValue" << std::endl;
        std::cout << "depth: " << offsetof(VkClearDepthStencilValue, depth) << std::endl;
        std::cout << "stencil: " << offsetof(VkClearDepthStencilValue, stencil) << std::endl;
    std::cout << std::endl;

    std::cout << "VkClearValue" << std::endl;
        std::cout << "color: " << offsetof(VkClearValue, color) << std::endl;
        std::cout << "depthStencil: " << offsetof(VkClearValue, depthStencil) << std::endl;
    std::cout << std::endl;

    std::cout << "VkClearAttachment" << std::endl;
        std::cout << "aspectMask: " << offsetof(VkClearAttachment, aspectMask) << std::endl;
        std::cout << "colorAttachment: " << offsetof(VkClearAttachment, colorAttachment) << std::endl;
        std::cout << "clearValue: " << offsetof(VkClearAttachment, clearValue) << std::endl;
    std::cout << std::endl;

    std::cout << "VkAttachmentDescription" << std::endl;
        std::cout << "flags: " << offsetof(VkAttachmentDescription, flags) << std::endl;
        std::cout << "format: " << offsetof(VkAttachmentDescription, format) << std::endl;
        std::cout << "samples: " << offsetof(VkAttachmentDescription, samples) << std::endl;
        std::cout << "loadOp: " << offsetof(VkAttachmentDescription, loadOp) << std::endl;
        std::cout << "storeOp: " << offsetof(VkAttachmentDescription, storeOp) << std::endl;
        std::cout << "stencilLoadOp: " << offsetof(VkAttachmentDescription, stencilLoadOp) << std::endl;
        std::cout << "stencilStoreOp: " << offsetof(VkAttachmentDescription, stencilStoreOp) << std::endl;
        std::cout << "initialLayout: " << offsetof(VkAttachmentDescription, initialLayout) << std::endl;
        std::cout << "finalLayout: " << offsetof(VkAttachmentDescription, finalLayout) << std::endl;
    std::cout << std::endl;

    std::cout << "VkAttachmentReference" << std::endl;
        std::cout << "attachment: " << offsetof(VkAttachmentReference, attachment) << std::endl;
        std::cout << "layout: " << offsetof(VkAttachmentReference, layout) << std::endl;
    std::cout << std::endl;

    std::cout << "VkSubpassDescription" << std::endl;
        std::cout << "flags: " << offsetof(VkSubpassDescription, flags) << std::endl;
        std::cout << "pipelineBindPoint: " << offsetof(VkSubpassDescription, pipelineBindPoint) << std::endl;
        std::cout << "inputAttachmentCount: " << offsetof(VkSubpassDescription, inputAttachmentCount) << std::endl;
        std::cout << "pInputAttachments: " << offsetof(VkSubpassDescription, pInputAttachments) << std::endl;
        std::cout << "colorAttachmentCount: " << offsetof(VkSubpassDescription, colorAttachmentCount) << std::endl;
        std::cout << "pColorAttachments: " << offsetof(VkSubpassDescription, pColorAttachments) << std::endl;
        std::cout << "pResolveAttachments: " << offsetof(VkSubpassDescription, pResolveAttachments) << std::endl;
        std::cout << "pDepthStencilAttachment: " << offsetof(VkSubpassDescription, pDepthStencilAttachment) << std::endl;
        std::cout << "preserveAttachmentCount: " << offsetof(VkSubpassDescription, preserveAttachmentCount) << std::endl;
        std::cout << "pPreserveAttachments: " << offsetof(VkSubpassDescription, pPreserveAttachments) << std::endl;
    std::cout << std::endl;

    std::cout << "VkSubpassDependency" << std::endl;
        std::cout << "srcSubpass: " << offsetof(VkSubpassDependency, srcSubpass) << std::endl;
        std::cout << "dstSubpass: " << offsetof(VkSubpassDependency, dstSubpass) << std::endl;
        std::cout << "srcStageMask: " << offsetof(VkSubpassDependency, srcStageMask) << std::endl;
        std::cout << "dstStageMask: " << offsetof(VkSubpassDependency, dstStageMask) << std::endl;
        std::cout << "srcAccessMask: " << offsetof(VkSubpassDependency, srcAccessMask) << std::endl;
        std::cout << "dstAccessMask: " << offsetof(VkSubpassDependency, dstAccessMask) << std::endl;
        std::cout << "dependencyFlags: " << offsetof(VkSubpassDependency, dependencyFlags) << std::endl;
    std::cout << std::endl;

    std::cout << "VkRenderPassCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkRenderPassCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkRenderPassCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkRenderPassCreateInfo, flags) << std::endl;
        std::cout << "attachmentCount: " << offsetof(VkRenderPassCreateInfo, attachmentCount) << std::endl;
        std::cout << "pAttachments: " << offsetof(VkRenderPassCreateInfo, pAttachments) << std::endl;
        std::cout << "subpassCount: " << offsetof(VkRenderPassCreateInfo, subpassCount) << std::endl;
        std::cout << "pSubpasses: " << offsetof(VkRenderPassCreateInfo, pSubpasses) << std::endl;
        std::cout << "dependencyCount: " << offsetof(VkRenderPassCreateInfo, dependencyCount) << std::endl;
        std::cout << "pDependencies: " << offsetof(VkRenderPassCreateInfo, pDependencies) << std::endl;
    std::cout << std::endl;

    std::cout << "VkEventCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkEventCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkEventCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkEventCreateInfo, flags) << std::endl;
    std::cout << std::endl;

    std::cout << "VkFenceCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkFenceCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkFenceCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkFenceCreateInfo, flags) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPhysicalDeviceFeatures" << std::endl;
        std::cout << "robustBufferAccess: " << offsetof(VkPhysicalDeviceFeatures, robustBufferAccess) << std::endl;
        std::cout << "fullDrawIndexUint32: " << offsetof(VkPhysicalDeviceFeatures, fullDrawIndexUint32) << std::endl;
        std::cout << "imageCubeArray: " << offsetof(VkPhysicalDeviceFeatures, imageCubeArray) << std::endl;
        std::cout << "independentBlend: " << offsetof(VkPhysicalDeviceFeatures, independentBlend) << std::endl;
        std::cout << "geometryShader: " << offsetof(VkPhysicalDeviceFeatures, geometryShader) << std::endl;
        std::cout << "tessellationShader: " << offsetof(VkPhysicalDeviceFeatures, tessellationShader) << std::endl;
        std::cout << "sampleRateShading: " << offsetof(VkPhysicalDeviceFeatures, sampleRateShading) << std::endl;
        std::cout << "dualSrcBlend: " << offsetof(VkPhysicalDeviceFeatures, dualSrcBlend) << std::endl;
        std::cout << "logicOp: " << offsetof(VkPhysicalDeviceFeatures, logicOp) << std::endl;
        std::cout << "multiDrawIndirect: " << offsetof(VkPhysicalDeviceFeatures, multiDrawIndirect) << std::endl;
        std::cout << "drawIndirectFirstInstance: " << offsetof(VkPhysicalDeviceFeatures, drawIndirectFirstInstance) << std::endl;
        std::cout << "depthClamp: " << offsetof(VkPhysicalDeviceFeatures, depthClamp) << std::endl;
        std::cout << "depthBiasClamp: " << offsetof(VkPhysicalDeviceFeatures, depthBiasClamp) << std::endl;
        std::cout << "fillModeNonSolid: " << offsetof(VkPhysicalDeviceFeatures, fillModeNonSolid) << std::endl;
        std::cout << "depthBounds: " << offsetof(VkPhysicalDeviceFeatures, depthBounds) << std::endl;
        std::cout << "wideLines: " << offsetof(VkPhysicalDeviceFeatures, wideLines) << std::endl;
        std::cout << "largePoints: " << offsetof(VkPhysicalDeviceFeatures, largePoints) << std::endl;
        std::cout << "alphaToOne: " << offsetof(VkPhysicalDeviceFeatures, alphaToOne) << std::endl;
        std::cout << "multiViewport: " << offsetof(VkPhysicalDeviceFeatures, multiViewport) << std::endl;
        std::cout << "samplerAnisotropy: " << offsetof(VkPhysicalDeviceFeatures, samplerAnisotropy) << std::endl;
        std::cout << "textureCompressionETC2: " << offsetof(VkPhysicalDeviceFeatures, textureCompressionETC2) << std::endl;
        std::cout << "textureCompressionASTC_LDR: " << offsetof(VkPhysicalDeviceFeatures, textureCompressionASTC_LDR) << std::endl;
        std::cout << "textureCompressionBC: " << offsetof(VkPhysicalDeviceFeatures, textureCompressionBC) << std::endl;
        std::cout << "occlusionQueryPrecise: " << offsetof(VkPhysicalDeviceFeatures, occlusionQueryPrecise) << std::endl;
        std::cout << "pipelineStatisticsQuery: " << offsetof(VkPhysicalDeviceFeatures, pipelineStatisticsQuery) << std::endl;
        std::cout << "vertexPipelineStoresAndAtomics: " << offsetof(VkPhysicalDeviceFeatures, vertexPipelineStoresAndAtomics) << std::endl;
        std::cout << "fragmentStoresAndAtomics: " << offsetof(VkPhysicalDeviceFeatures, fragmentStoresAndAtomics) << std::endl;
        std::cout << "shaderTessellationAndGeometryPointSize: " << offsetof(VkPhysicalDeviceFeatures, shaderTessellationAndGeometryPointSize) << std::endl;
        std::cout << "shaderImageGatherExtended: " << offsetof(VkPhysicalDeviceFeatures, shaderImageGatherExtended) << std::endl;
        std::cout << "shaderStorageImageExtendedFormats: " << offsetof(VkPhysicalDeviceFeatures, shaderStorageImageExtendedFormats) << std::endl;
        std::cout << "shaderStorageImageMultisample: " << offsetof(VkPhysicalDeviceFeatures, shaderStorageImageMultisample) << std::endl;
        std::cout << "shaderStorageImageReadWithoutFormat: " << offsetof(VkPhysicalDeviceFeatures, shaderStorageImageReadWithoutFormat) << std::endl;
        std::cout << "shaderStorageImageWriteWithoutFormat: " << offsetof(VkPhysicalDeviceFeatures, shaderStorageImageWriteWithoutFormat) << std::endl;
        std::cout << "shaderUniformBufferArrayDynamicIndexing: " << offsetof(VkPhysicalDeviceFeatures, shaderUniformBufferArrayDynamicIndexing) << std::endl;
        std::cout << "shaderSampledImageArrayDynamicIndexing: " << offsetof(VkPhysicalDeviceFeatures, shaderSampledImageArrayDynamicIndexing) << std::endl;
        std::cout << "shaderStorageBufferArrayDynamicIndexing: " << offsetof(VkPhysicalDeviceFeatures, shaderStorageBufferArrayDynamicIndexing) << std::endl;
        std::cout << "shaderStorageImageArrayDynamicIndexing: " << offsetof(VkPhysicalDeviceFeatures, shaderStorageImageArrayDynamicIndexing) << std::endl;
        std::cout << "shaderClipDistance: " << offsetof(VkPhysicalDeviceFeatures, shaderClipDistance) << std::endl;
        std::cout << "shaderCullDistance: " << offsetof(VkPhysicalDeviceFeatures, shaderCullDistance) << std::endl;
        std::cout << "shaderFloat64: " << offsetof(VkPhysicalDeviceFeatures, shaderFloat64) << std::endl;
        std::cout << "shaderInt64: " << offsetof(VkPhysicalDeviceFeatures, shaderInt64) << std::endl;
        std::cout << "shaderInt16: " << offsetof(VkPhysicalDeviceFeatures, shaderInt16) << std::endl;
        std::cout << "shaderResourceResidency: " << offsetof(VkPhysicalDeviceFeatures, shaderResourceResidency) << std::endl;
        std::cout << "shaderResourceMinLod: " << offsetof(VkPhysicalDeviceFeatures, shaderResourceMinLod) << std::endl;
        std::cout << "sparseBinding: " << offsetof(VkPhysicalDeviceFeatures, sparseBinding) << std::endl;
        std::cout << "sparseResidencyBuffer: " << offsetof(VkPhysicalDeviceFeatures, sparseResidencyBuffer) << std::endl;
        std::cout << "sparseResidencyImage2D: " << offsetof(VkPhysicalDeviceFeatures, sparseResidencyImage2D) << std::endl;
        std::cout << "sparseResidencyImage3D: " << offsetof(VkPhysicalDeviceFeatures, sparseResidencyImage3D) << std::endl;
        std::cout << "sparseResidency2Samples: " << offsetof(VkPhysicalDeviceFeatures, sparseResidency2Samples) << std::endl;
        std::cout << "sparseResidency4Samples: " << offsetof(VkPhysicalDeviceFeatures, sparseResidency4Samples) << std::endl;
        std::cout << "sparseResidency8Samples: " << offsetof(VkPhysicalDeviceFeatures, sparseResidency8Samples) << std::endl;
        std::cout << "sparseResidency16Samples: " << offsetof(VkPhysicalDeviceFeatures, sparseResidency16Samples) << std::endl;
        std::cout << "sparseResidencyAliased: " << offsetof(VkPhysicalDeviceFeatures, sparseResidencyAliased) << std::endl;
        std::cout << "variableMultisampleRate: " << offsetof(VkPhysicalDeviceFeatures, variableMultisampleRate) << std::endl;
        std::cout << "inheritedQueries: " << offsetof(VkPhysicalDeviceFeatures, inheritedQueries) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPhysicalDeviceSparseProperties" << std::endl;
        std::cout << "residencyStandard2DBlockShape: " << offsetof(VkPhysicalDeviceSparseProperties, residencyStandard2DBlockShape) << std::endl;
        std::cout << "residencyStandard2DMultisampleBlockShape: " << offsetof(VkPhysicalDeviceSparseProperties, residencyStandard2DMultisampleBlockShape) << std::endl;
        std::cout << "residencyStandard3DBlockShape: " << offsetof(VkPhysicalDeviceSparseProperties, residencyStandard3DBlockShape) << std::endl;
        std::cout << "residencyAlignedMipSize: " << offsetof(VkPhysicalDeviceSparseProperties, residencyAlignedMipSize) << std::endl;
        std::cout << "residencyNonResidentStrict: " << offsetof(VkPhysicalDeviceSparseProperties, residencyNonResidentStrict) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPhysicalDeviceLimits" << std::endl;
        std::cout << "maxImageDimension1D: " << offsetof(VkPhysicalDeviceLimits, maxImageDimension1D) << std::endl;
        std::cout << "maxImageDimension2D: " << offsetof(VkPhysicalDeviceLimits, maxImageDimension2D) << std::endl;
        std::cout << "maxImageDimension3D: " << offsetof(VkPhysicalDeviceLimits, maxImageDimension3D) << std::endl;
        std::cout << "maxImageDimensionCube: " << offsetof(VkPhysicalDeviceLimits, maxImageDimensionCube) << std::endl;
        std::cout << "maxImageArrayLayers: " << offsetof(VkPhysicalDeviceLimits, maxImageArrayLayers) << std::endl;
        std::cout << "maxTexelBufferElements: " << offsetof(VkPhysicalDeviceLimits, maxTexelBufferElements) << std::endl;
        std::cout << "maxUniformBufferRange: " << offsetof(VkPhysicalDeviceLimits, maxUniformBufferRange) << std::endl;
        std::cout << "maxStorageBufferRange: " << offsetof(VkPhysicalDeviceLimits, maxStorageBufferRange) << std::endl;
        std::cout << "maxPushConstantsSize: " << offsetof(VkPhysicalDeviceLimits, maxPushConstantsSize) << std::endl;
        std::cout << "maxMemoryAllocationCount: " << offsetof(VkPhysicalDeviceLimits, maxMemoryAllocationCount) << std::endl;
        std::cout << "maxSamplerAllocationCount: " << offsetof(VkPhysicalDeviceLimits, maxSamplerAllocationCount) << std::endl;
        std::cout << "bufferImageGranularity: " << offsetof(VkPhysicalDeviceLimits, bufferImageGranularity) << std::endl;
        std::cout << "sparseAddressSpaceSize: " << offsetof(VkPhysicalDeviceLimits, sparseAddressSpaceSize) << std::endl;
        std::cout << "maxBoundDescriptorSets: " << offsetof(VkPhysicalDeviceLimits, maxBoundDescriptorSets) << std::endl;
        std::cout << "maxPerStageDescriptorSamplers: " << offsetof(VkPhysicalDeviceLimits, maxPerStageDescriptorSamplers) << std::endl;
        std::cout << "maxPerStageDescriptorUniformBuffers: " << offsetof(VkPhysicalDeviceLimits, maxPerStageDescriptorUniformBuffers) << std::endl;
        std::cout << "maxPerStageDescriptorStorageBuffers: " << offsetof(VkPhysicalDeviceLimits, maxPerStageDescriptorStorageBuffers) << std::endl;
        std::cout << "maxPerStageDescriptorSampledImages: " << offsetof(VkPhysicalDeviceLimits, maxPerStageDescriptorSampledImages) << std::endl;
        std::cout << "maxPerStageDescriptorStorageImages: " << offsetof(VkPhysicalDeviceLimits, maxPerStageDescriptorStorageImages) << std::endl;
        std::cout << "maxPerStageDescriptorInputAttachments: " << offsetof(VkPhysicalDeviceLimits, maxPerStageDescriptorInputAttachments) << std::endl;
        std::cout << "maxPerStageResources: " << offsetof(VkPhysicalDeviceLimits, maxPerStageResources) << std::endl;
        std::cout << "maxDescriptorSetSamplers: " << offsetof(VkPhysicalDeviceLimits, maxDescriptorSetSamplers) << std::endl;
        std::cout << "maxDescriptorSetUniformBuffers: " << offsetof(VkPhysicalDeviceLimits, maxDescriptorSetUniformBuffers) << std::endl;
        std::cout << "maxDescriptorSetUniformBuffersDynamic: " << offsetof(VkPhysicalDeviceLimits, maxDescriptorSetUniformBuffersDynamic) << std::endl;
        std::cout << "maxDescriptorSetStorageBuffers: " << offsetof(VkPhysicalDeviceLimits, maxDescriptorSetStorageBuffers) << std::endl;
        std::cout << "maxDescriptorSetStorageBuffersDynamic: " << offsetof(VkPhysicalDeviceLimits, maxDescriptorSetStorageBuffersDynamic) << std::endl;
        std::cout << "maxDescriptorSetSampledImages: " << offsetof(VkPhysicalDeviceLimits, maxDescriptorSetSampledImages) << std::endl;
        std::cout << "maxDescriptorSetStorageImages: " << offsetof(VkPhysicalDeviceLimits, maxDescriptorSetStorageImages) << std::endl;
        std::cout << "maxDescriptorSetInputAttachments: " << offsetof(VkPhysicalDeviceLimits, maxDescriptorSetInputAttachments) << std::endl;
        std::cout << "maxVertexInputAttributes: " << offsetof(VkPhysicalDeviceLimits, maxVertexInputAttributes) << std::endl;
        std::cout << "maxVertexInputBindings: " << offsetof(VkPhysicalDeviceLimits, maxVertexInputBindings) << std::endl;
        std::cout << "maxVertexInputAttributeOffset: " << offsetof(VkPhysicalDeviceLimits, maxVertexInputAttributeOffset) << std::endl;
        std::cout << "maxVertexInputBindingStride: " << offsetof(VkPhysicalDeviceLimits, maxVertexInputBindingStride) << std::endl;
        std::cout << "maxVertexOutputComponents: " << offsetof(VkPhysicalDeviceLimits, maxVertexOutputComponents) << std::endl;
        std::cout << "maxTessellationGenerationLevel: " << offsetof(VkPhysicalDeviceLimits, maxTessellationGenerationLevel) << std::endl;
        std::cout << "maxTessellationPatchSize: " << offsetof(VkPhysicalDeviceLimits, maxTessellationPatchSize) << std::endl;
        std::cout << "maxTessellationControlPerVertexInputComponents: " << offsetof(VkPhysicalDeviceLimits, maxTessellationControlPerVertexInputComponents) << std::endl;
        std::cout << "maxTessellationControlPerVertexOutputComponents: " << offsetof(VkPhysicalDeviceLimits, maxTessellationControlPerVertexOutputComponents) << std::endl;
        std::cout << "maxTessellationControlPerPatchOutputComponents: " << offsetof(VkPhysicalDeviceLimits, maxTessellationControlPerPatchOutputComponents) << std::endl;
        std::cout << "maxTessellationControlTotalOutputComponents: " << offsetof(VkPhysicalDeviceLimits, maxTessellationControlTotalOutputComponents) << std::endl;
        std::cout << "maxTessellationEvaluationInputComponents: " << offsetof(VkPhysicalDeviceLimits, maxTessellationEvaluationInputComponents) << std::endl;
        std::cout << "maxTessellationEvaluationOutputComponents: " << offsetof(VkPhysicalDeviceLimits, maxTessellationEvaluationOutputComponents) << std::endl;
        std::cout << "maxGeometryShaderInvocations: " << offsetof(VkPhysicalDeviceLimits, maxGeometryShaderInvocations) << std::endl;
        std::cout << "maxGeometryInputComponents: " << offsetof(VkPhysicalDeviceLimits, maxGeometryInputComponents) << std::endl;
        std::cout << "maxGeometryOutputComponents: " << offsetof(VkPhysicalDeviceLimits, maxGeometryOutputComponents) << std::endl;
        std::cout << "maxGeometryOutputVertices: " << offsetof(VkPhysicalDeviceLimits, maxGeometryOutputVertices) << std::endl;
        std::cout << "maxGeometryTotalOutputComponents: " << offsetof(VkPhysicalDeviceLimits, maxGeometryTotalOutputComponents) << std::endl;
        std::cout << "maxFragmentInputComponents: " << offsetof(VkPhysicalDeviceLimits, maxFragmentInputComponents) << std::endl;
        std::cout << "maxFragmentOutputAttachments: " << offsetof(VkPhysicalDeviceLimits, maxFragmentOutputAttachments) << std::endl;
        std::cout << "maxFragmentDualSrcAttachments: " << offsetof(VkPhysicalDeviceLimits, maxFragmentDualSrcAttachments) << std::endl;
        std::cout << "maxFragmentCombinedOutputResources: " << offsetof(VkPhysicalDeviceLimits, maxFragmentCombinedOutputResources) << std::endl;
        std::cout << "maxComputeSharedMemorySize: " << offsetof(VkPhysicalDeviceLimits, maxComputeSharedMemorySize) << std::endl;
        std::cout << "maxComputeWorkGroupCount: " << offsetof(VkPhysicalDeviceLimits, maxComputeWorkGroupCount) << std::endl;
        std::cout << "maxComputeWorkGroupInvocations: " << offsetof(VkPhysicalDeviceLimits, maxComputeWorkGroupInvocations) << std::endl;
        std::cout << "maxComputeWorkGroupSize: " << offsetof(VkPhysicalDeviceLimits, maxComputeWorkGroupSize) << std::endl;
        std::cout << "subPixelPrecisionBits: " << offsetof(VkPhysicalDeviceLimits, subPixelPrecisionBits) << std::endl;
        std::cout << "subTexelPrecisionBits: " << offsetof(VkPhysicalDeviceLimits, subTexelPrecisionBits) << std::endl;
        std::cout << "mipmapPrecisionBits: " << offsetof(VkPhysicalDeviceLimits, mipmapPrecisionBits) << std::endl;
        std::cout << "maxDrawIndexedIndexValue: " << offsetof(VkPhysicalDeviceLimits, maxDrawIndexedIndexValue) << std::endl;
        std::cout << "maxDrawIndirectCount: " << offsetof(VkPhysicalDeviceLimits, maxDrawIndirectCount) << std::endl;
        std::cout << "maxSamplerLodBias: " << offsetof(VkPhysicalDeviceLimits, maxSamplerLodBias) << std::endl;
        std::cout << "maxSamplerAnisotropy: " << offsetof(VkPhysicalDeviceLimits, maxSamplerAnisotropy) << std::endl;
        std::cout << "maxViewports: " << offsetof(VkPhysicalDeviceLimits, maxViewports) << std::endl;
        std::cout << "maxViewportDimensions: " << offsetof(VkPhysicalDeviceLimits, maxViewportDimensions) << std::endl;
        std::cout << "viewportBoundsRange: " << offsetof(VkPhysicalDeviceLimits, viewportBoundsRange) << std::endl;
        std::cout << "viewportSubPixelBits: " << offsetof(VkPhysicalDeviceLimits, viewportSubPixelBits) << std::endl;
        std::cout << "minMemoryMapAlignment: " << offsetof(VkPhysicalDeviceLimits, minMemoryMapAlignment) << std::endl;
        std::cout << "minTexelBufferOffsetAlignment: " << offsetof(VkPhysicalDeviceLimits, minTexelBufferOffsetAlignment) << std::endl;
        std::cout << "minUniformBufferOffsetAlignment: " << offsetof(VkPhysicalDeviceLimits, minUniformBufferOffsetAlignment) << std::endl;
        std::cout << "minStorageBufferOffsetAlignment: " << offsetof(VkPhysicalDeviceLimits, minStorageBufferOffsetAlignment) << std::endl;
        std::cout << "minTexelOffset: " << offsetof(VkPhysicalDeviceLimits, minTexelOffset) << std::endl;
        std::cout << "maxTexelOffset: " << offsetof(VkPhysicalDeviceLimits, maxTexelOffset) << std::endl;
        std::cout << "minTexelGatherOffset: " << offsetof(VkPhysicalDeviceLimits, minTexelGatherOffset) << std::endl;
        std::cout << "maxTexelGatherOffset: " << offsetof(VkPhysicalDeviceLimits, maxTexelGatherOffset) << std::endl;
        std::cout << "minInterpolationOffset: " << offsetof(VkPhysicalDeviceLimits, minInterpolationOffset) << std::endl;
        std::cout << "maxInterpolationOffset: " << offsetof(VkPhysicalDeviceLimits, maxInterpolationOffset) << std::endl;
        std::cout << "subPixelInterpolationOffsetBits: " << offsetof(VkPhysicalDeviceLimits, subPixelInterpolationOffsetBits) << std::endl;
        std::cout << "maxFramebufferWidth: " << offsetof(VkPhysicalDeviceLimits, maxFramebufferWidth) << std::endl;
        std::cout << "maxFramebufferHeight: " << offsetof(VkPhysicalDeviceLimits, maxFramebufferHeight) << std::endl;
        std::cout << "maxFramebufferLayers: " << offsetof(VkPhysicalDeviceLimits, maxFramebufferLayers) << std::endl;
        std::cout << "framebufferColorSampleCounts: " << offsetof(VkPhysicalDeviceLimits, framebufferColorSampleCounts) << std::endl;
        std::cout << "framebufferDepthSampleCounts: " << offsetof(VkPhysicalDeviceLimits, framebufferDepthSampleCounts) << std::endl;
        std::cout << "framebufferStencilSampleCounts: " << offsetof(VkPhysicalDeviceLimits, framebufferStencilSampleCounts) << std::endl;
        std::cout << "framebufferNoAttachmentsSampleCounts: " << offsetof(VkPhysicalDeviceLimits, framebufferNoAttachmentsSampleCounts) << std::endl;
        std::cout << "maxColorAttachments: " << offsetof(VkPhysicalDeviceLimits, maxColorAttachments) << std::endl;
        std::cout << "sampledImageColorSampleCounts: " << offsetof(VkPhysicalDeviceLimits, sampledImageColorSampleCounts) << std::endl;
        std::cout << "sampledImageIntegerSampleCounts: " << offsetof(VkPhysicalDeviceLimits, sampledImageIntegerSampleCounts) << std::endl;
        std::cout << "sampledImageDepthSampleCounts: " << offsetof(VkPhysicalDeviceLimits, sampledImageDepthSampleCounts) << std::endl;
        std::cout << "sampledImageStencilSampleCounts: " << offsetof(VkPhysicalDeviceLimits, sampledImageStencilSampleCounts) << std::endl;
        std::cout << "storageImageSampleCounts: " << offsetof(VkPhysicalDeviceLimits, storageImageSampleCounts) << std::endl;
        std::cout << "maxSampleMaskWords: " << offsetof(VkPhysicalDeviceLimits, maxSampleMaskWords) << std::endl;
        std::cout << "timestampComputeAndGraphics: " << offsetof(VkPhysicalDeviceLimits, timestampComputeAndGraphics) << std::endl;
        std::cout << "timestampPeriod: " << offsetof(VkPhysicalDeviceLimits, timestampPeriod) << std::endl;
        std::cout << "maxClipDistances: " << offsetof(VkPhysicalDeviceLimits, maxClipDistances) << std::endl;
        std::cout << "maxCullDistances: " << offsetof(VkPhysicalDeviceLimits, maxCullDistances) << std::endl;
        std::cout << "maxCombinedClipAndCullDistances: " << offsetof(VkPhysicalDeviceLimits, maxCombinedClipAndCullDistances) << std::endl;
        std::cout << "discreteQueuePriorities: " << offsetof(VkPhysicalDeviceLimits, discreteQueuePriorities) << std::endl;
        std::cout << "pointSizeRange: " << offsetof(VkPhysicalDeviceLimits, pointSizeRange) << std::endl;
        std::cout << "lineWidthRange: " << offsetof(VkPhysicalDeviceLimits, lineWidthRange) << std::endl;
        std::cout << "pointSizeGranularity: " << offsetof(VkPhysicalDeviceLimits, pointSizeGranularity) << std::endl;
        std::cout << "lineWidthGranularity: " << offsetof(VkPhysicalDeviceLimits, lineWidthGranularity) << std::endl;
        std::cout << "strictLines: " << offsetof(VkPhysicalDeviceLimits, strictLines) << std::endl;
        std::cout << "standardSampleLocations: " << offsetof(VkPhysicalDeviceLimits, standardSampleLocations) << std::endl;
        std::cout << "optimalBufferCopyOffsetAlignment: " << offsetof(VkPhysicalDeviceLimits, optimalBufferCopyOffsetAlignment) << std::endl;
        std::cout << "optimalBufferCopyRowPitchAlignment: " << offsetof(VkPhysicalDeviceLimits, optimalBufferCopyRowPitchAlignment) << std::endl;
        std::cout << "nonCoherentAtomSize: " << offsetof(VkPhysicalDeviceLimits, nonCoherentAtomSize) << std::endl;
    std::cout << std::endl;

    std::cout << "VkSemaphoreCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkSemaphoreCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkSemaphoreCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkSemaphoreCreateInfo, flags) << std::endl;
    std::cout << std::endl;

    std::cout << "VkQueryPoolCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkQueryPoolCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkQueryPoolCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkQueryPoolCreateInfo, flags) << std::endl;
        std::cout << "queryType: " << offsetof(VkQueryPoolCreateInfo, queryType) << std::endl;
        std::cout << "queryCount: " << offsetof(VkQueryPoolCreateInfo, queryCount) << std::endl;
        std::cout << "pipelineStatistics: " << offsetof(VkQueryPoolCreateInfo, pipelineStatistics) << std::endl;
    std::cout << std::endl;

    std::cout << "VkFramebufferCreateInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkFramebufferCreateInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkFramebufferCreateInfo, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkFramebufferCreateInfo, flags) << std::endl;
        std::cout << "renderPass: " << offsetof(VkFramebufferCreateInfo, renderPass) << std::endl;
        std::cout << "attachmentCount: " << offsetof(VkFramebufferCreateInfo, attachmentCount) << std::endl;
        std::cout << "pAttachments: " << offsetof(VkFramebufferCreateInfo, pAttachments) << std::endl;
        std::cout << "width: " << offsetof(VkFramebufferCreateInfo, width) << std::endl;
        std::cout << "height: " << offsetof(VkFramebufferCreateInfo, height) << std::endl;
        std::cout << "layers: " << offsetof(VkFramebufferCreateInfo, layers) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDrawIndirectCommand" << std::endl;
        std::cout << "vertexCount: " << offsetof(VkDrawIndirectCommand, vertexCount) << std::endl;
        std::cout << "instanceCount: " << offsetof(VkDrawIndirectCommand, instanceCount) << std::endl;
        std::cout << "firstVertex: " << offsetof(VkDrawIndirectCommand, firstVertex) << std::endl;
        std::cout << "firstInstance: " << offsetof(VkDrawIndirectCommand, firstInstance) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDrawIndexedIndirectCommand" << std::endl;
        std::cout << "indexCount: " << offsetof(VkDrawIndexedIndirectCommand, indexCount) << std::endl;
        std::cout << "instanceCount: " << offsetof(VkDrawIndexedIndirectCommand, instanceCount) << std::endl;
        std::cout << "firstIndex: " << offsetof(VkDrawIndexedIndirectCommand, firstIndex) << std::endl;
        std::cout << "vertexOffset: " << offsetof(VkDrawIndexedIndirectCommand, vertexOffset) << std::endl;
        std::cout << "firstInstance: " << offsetof(VkDrawIndexedIndirectCommand, firstInstance) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDispatchIndirectCommand" << std::endl;
        std::cout << "x: " << offsetof(VkDispatchIndirectCommand, x) << std::endl;
        std::cout << "y: " << offsetof(VkDispatchIndirectCommand, y) << std::endl;
        std::cout << "z: " << offsetof(VkDispatchIndirectCommand, z) << std::endl;
    std::cout << std::endl;

    std::cout << "VkSubmitInfo" << std::endl;
        std::cout << "sType: " << offsetof(VkSubmitInfo, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkSubmitInfo, pNext) << std::endl;
        std::cout << "waitSemaphoreCount: " << offsetof(VkSubmitInfo, waitSemaphoreCount) << std::endl;
        std::cout << "pWaitSemaphores: " << offsetof(VkSubmitInfo, pWaitSemaphores) << std::endl;
        std::cout << "pWaitDstStageMask: " << offsetof(VkSubmitInfo, pWaitDstStageMask) << std::endl;
        std::cout << "commandBufferCount: " << offsetof(VkSubmitInfo, commandBufferCount) << std::endl;
        std::cout << "pCommandBuffers: " << offsetof(VkSubmitInfo, pCommandBuffers) << std::endl;
        std::cout << "signalSemaphoreCount: " << offsetof(VkSubmitInfo, signalSemaphoreCount) << std::endl;
        std::cout << "pSignalSemaphores: " << offsetof(VkSubmitInfo, pSignalSemaphores) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDisplayPropertiesKHR" << std::endl;
        std::cout << "display: " << offsetof(VkDisplayPropertiesKHR, display) << std::endl;
        std::cout << "displayName: " << offsetof(VkDisplayPropertiesKHR, displayName) << std::endl;
        std::cout << "physicalDimensions: " << offsetof(VkDisplayPropertiesKHR, physicalDimensions) << std::endl;
        std::cout << "physicalResolution: " << offsetof(VkDisplayPropertiesKHR, physicalResolution) << std::endl;
        std::cout << "supportedTransforms: " << offsetof(VkDisplayPropertiesKHR, supportedTransforms) << std::endl;
        std::cout << "planeReorderPossible: " << offsetof(VkDisplayPropertiesKHR, planeReorderPossible) << std::endl;
        std::cout << "persistentContent: " << offsetof(VkDisplayPropertiesKHR, persistentContent) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDisplayPlanePropertiesKHR" << std::endl;
        std::cout << "currentDisplay: " << offsetof(VkDisplayPlanePropertiesKHR, currentDisplay) << std::endl;
        std::cout << "currentStackIndex: " << offsetof(VkDisplayPlanePropertiesKHR, currentStackIndex) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDisplayModeParametersKHR" << std::endl;
        std::cout << "visibleRegion: " << offsetof(VkDisplayModeParametersKHR, visibleRegion) << std::endl;
        std::cout << "refreshRate: " << offsetof(VkDisplayModeParametersKHR, refreshRate) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDisplayModePropertiesKHR" << std::endl;
        std::cout << "displayMode: " << offsetof(VkDisplayModePropertiesKHR, displayMode) << std::endl;
        std::cout << "parameters: " << offsetof(VkDisplayModePropertiesKHR, parameters) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDisplayModeCreateInfoKHR" << std::endl;
        std::cout << "sType: " << offsetof(VkDisplayModeCreateInfoKHR, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkDisplayModeCreateInfoKHR, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkDisplayModeCreateInfoKHR, flags) << std::endl;
        std::cout << "parameters: " << offsetof(VkDisplayModeCreateInfoKHR, parameters) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDisplayPlaneCapabilitiesKHR" << std::endl;
        std::cout << "supportedAlpha: " << offsetof(VkDisplayPlaneCapabilitiesKHR, supportedAlpha) << std::endl;
        std::cout << "minSrcPosition: " << offsetof(VkDisplayPlaneCapabilitiesKHR, minSrcPosition) << std::endl;
        std::cout << "maxSrcPosition: " << offsetof(VkDisplayPlaneCapabilitiesKHR, maxSrcPosition) << std::endl;
        std::cout << "minSrcExtent: " << offsetof(VkDisplayPlaneCapabilitiesKHR, minSrcExtent) << std::endl;
        std::cout << "maxSrcExtent: " << offsetof(VkDisplayPlaneCapabilitiesKHR, maxSrcExtent) << std::endl;
        std::cout << "minDstPosition: " << offsetof(VkDisplayPlaneCapabilitiesKHR, minDstPosition) << std::endl;
        std::cout << "maxDstPosition: " << offsetof(VkDisplayPlaneCapabilitiesKHR, maxDstPosition) << std::endl;
        std::cout << "minDstExtent: " << offsetof(VkDisplayPlaneCapabilitiesKHR, minDstExtent) << std::endl;
        std::cout << "maxDstExtent: " << offsetof(VkDisplayPlaneCapabilitiesKHR, maxDstExtent) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDisplaySurfaceCreateInfoKHR" << std::endl;
        std::cout << "sType: " << offsetof(VkDisplaySurfaceCreateInfoKHR, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkDisplaySurfaceCreateInfoKHR, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkDisplaySurfaceCreateInfoKHR, flags) << std::endl;
        std::cout << "displayMode: " << offsetof(VkDisplaySurfaceCreateInfoKHR, displayMode) << std::endl;
        std::cout << "planeIndex: " << offsetof(VkDisplaySurfaceCreateInfoKHR, planeIndex) << std::endl;
        std::cout << "planeStackIndex: " << offsetof(VkDisplaySurfaceCreateInfoKHR, planeStackIndex) << std::endl;
        std::cout << "transform: " << offsetof(VkDisplaySurfaceCreateInfoKHR, transform) << std::endl;
        std::cout << "globalAlpha: " << offsetof(VkDisplaySurfaceCreateInfoKHR, globalAlpha) << std::endl;
        std::cout << "alphaMode: " << offsetof(VkDisplaySurfaceCreateInfoKHR, alphaMode) << std::endl;
        std::cout << "imageExtent: " << offsetof(VkDisplaySurfaceCreateInfoKHR, imageExtent) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDisplayPresentInfoKHR" << std::endl;
        std::cout << "sType: " << offsetof(VkDisplayPresentInfoKHR, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkDisplayPresentInfoKHR, pNext) << std::endl;
        std::cout << "srcRect: " << offsetof(VkDisplayPresentInfoKHR, srcRect) << std::endl;
        std::cout << "dstRect: " << offsetof(VkDisplayPresentInfoKHR, dstRect) << std::endl;
        std::cout << "persistent: " << offsetof(VkDisplayPresentInfoKHR, persistent) << std::endl;
    std::cout << std::endl;

    std::cout << "VkSurfaceCapabilitiesKHR" << std::endl;
        std::cout << "minImageCount: " << offsetof(VkSurfaceCapabilitiesKHR, minImageCount) << std::endl;
        std::cout << "maxImageCount: " << offsetof(VkSurfaceCapabilitiesKHR, maxImageCount) << std::endl;
        std::cout << "currentExtent: " << offsetof(VkSurfaceCapabilitiesKHR, currentExtent) << std::endl;
        std::cout << "minImageExtent: " << offsetof(VkSurfaceCapabilitiesKHR, minImageExtent) << std::endl;
        std::cout << "maxImageExtent: " << offsetof(VkSurfaceCapabilitiesKHR, maxImageExtent) << std::endl;
        std::cout << "maxImageArrayLayers: " << offsetof(VkSurfaceCapabilitiesKHR, maxImageArrayLayers) << std::endl;
        std::cout << "supportedTransforms: " << offsetof(VkSurfaceCapabilitiesKHR, supportedTransforms) << std::endl;
        std::cout << "currentTransform: " << offsetof(VkSurfaceCapabilitiesKHR, currentTransform) << std::endl;
        std::cout << "supportedCompositeAlpha: " << offsetof(VkSurfaceCapabilitiesKHR, supportedCompositeAlpha) << std::endl;
        std::cout << "supportedUsageFlags: " << offsetof(VkSurfaceCapabilitiesKHR, supportedUsageFlags) << std::endl;
    std::cout << std::endl;

    std::cout << "VkSurfaceFormatKHR" << std::endl;
        std::cout << "format: " << offsetof(VkSurfaceFormatKHR, format) << std::endl;
        std::cout << "colorSpace: " << offsetof(VkSurfaceFormatKHR, colorSpace) << std::endl;
    std::cout << std::endl;

    std::cout << "VkSwapchainCreateInfoKHR" << std::endl;
        std::cout << "sType: " << offsetof(VkSwapchainCreateInfoKHR, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkSwapchainCreateInfoKHR, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkSwapchainCreateInfoKHR, flags) << std::endl;
        std::cout << "surface: " << offsetof(VkSwapchainCreateInfoKHR, surface) << std::endl;
        std::cout << "minImageCount: " << offsetof(VkSwapchainCreateInfoKHR, minImageCount) << std::endl;
        std::cout << "imageFormat: " << offsetof(VkSwapchainCreateInfoKHR, imageFormat) << std::endl;
        std::cout << "imageColorSpace: " << offsetof(VkSwapchainCreateInfoKHR, imageColorSpace) << std::endl;
        std::cout << "imageExtent: " << offsetof(VkSwapchainCreateInfoKHR, imageExtent) << std::endl;
        std::cout << "imageArrayLayers: " << offsetof(VkSwapchainCreateInfoKHR, imageArrayLayers) << std::endl;
        std::cout << "imageUsage: " << offsetof(VkSwapchainCreateInfoKHR, imageUsage) << std::endl;
        std::cout << "imageSharingMode: " << offsetof(VkSwapchainCreateInfoKHR, imageSharingMode) << std::endl;
        std::cout << "queueFamilyIndexCount: " << offsetof(VkSwapchainCreateInfoKHR, queueFamilyIndexCount) << std::endl;
        std::cout << "pQueueFamilyIndices: " << offsetof(VkSwapchainCreateInfoKHR, pQueueFamilyIndices) << std::endl;
        std::cout << "preTransform: " << offsetof(VkSwapchainCreateInfoKHR, preTransform) << std::endl;
        std::cout << "compositeAlpha: " << offsetof(VkSwapchainCreateInfoKHR, compositeAlpha) << std::endl;
        std::cout << "presentMode: " << offsetof(VkSwapchainCreateInfoKHR, presentMode) << std::endl;
        std::cout << "clipped: " << offsetof(VkSwapchainCreateInfoKHR, clipped) << std::endl;
        std::cout << "oldSwapchain: " << offsetof(VkSwapchainCreateInfoKHR, oldSwapchain) << std::endl;
    std::cout << std::endl;

    std::cout << "VkPresentInfoKHR" << std::endl;
        std::cout << "sType: " << offsetof(VkPresentInfoKHR, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkPresentInfoKHR, pNext) << std::endl;
        std::cout << "waitSemaphoreCount: " << offsetof(VkPresentInfoKHR, waitSemaphoreCount) << std::endl;
        std::cout << "pWaitSemaphores: " << offsetof(VkPresentInfoKHR, pWaitSemaphores) << std::endl;
        std::cout << "swapchainCount: " << offsetof(VkPresentInfoKHR, swapchainCount) << std::endl;
        std::cout << "pSwapchains: " << offsetof(VkPresentInfoKHR, pSwapchains) << std::endl;
        std::cout << "pImageIndices: " << offsetof(VkPresentInfoKHR, pImageIndices) << std::endl;
        std::cout << "pResults: " << offsetof(VkPresentInfoKHR, pResults) << std::endl;
    std::cout << std::endl;

    std::cout << "VkDebugReportCallbackCreateInfoEXT" << std::endl;
        std::cout << "sType: " << offsetof(VkDebugReportCallbackCreateInfoEXT, sType) << std::endl;
        std::cout << "pNext: " << offsetof(VkDebugReportCallbackCreateInfoEXT, pNext) << std::endl;
        std::cout << "flags: " << offsetof(VkDebugReportCallbackCreateInfoEXT, flags) << std::endl;
        std::cout << "pfnCallback: " << offsetof(VkDebugReportCallbackCreateInfoEXT, pfnCallback) << std::endl;
        std::cout << "pUserData: " << offsetof(VkDebugReportCallbackCreateInfoEXT, pUserData) << std::endl;
    std::cout << std::endl;

}

<%@page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<%@taglib prefix="kendo" uri="http://www.kendoui.com/jsp/tags"%>
<%@taglib prefix="demo" tagdir="/WEB-INF/tags"%>

<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>

<c:url value="/grid/checkbox-selection/read" var="readUrl" />

<demo:header />
    <kendo:grid name="grid" pageable="true" sortable="true" persistSelection="true" height="550px" >
        <kendo:grid-columns>
        	<kendo:grid-column selectable="true" width="50px"/>
            <kendo:grid-column title="Product Name" field="productName" />
            <kendo:grid-column title="Unit Price" field="unitPrice" format="{0:c}" width="120px" />
            <kendo:grid-column title="Units In Stock" field="unitsInStock" width="120px" />
            <kendo:grid-column title="Discontinued" field="discontinued" width="120px"/>
        </kendo:grid-columns>
        <kendo:dataSource pageSize="20">
            <kendo:dataSource-transport>
                <kendo:dataSource-transport-read url="${readUrl}" dataType="json" type="POST" contentType="application/json"/>
            </kendo:dataSource-transport>
            <kendo:dataSource-schema>
                <kendo:dataSource-schema-model id="productId">
                </kendo:dataSource-schema-model>
            </kendo:dataSource-schema>
        </kendo:dataSource>
    </kendo:grid>    
<demo:footer />

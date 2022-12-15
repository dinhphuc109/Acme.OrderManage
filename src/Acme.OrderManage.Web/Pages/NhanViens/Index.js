$(function () {
    var l = abp.localization.getResource('OrderManage');

    var dataTable = $('#NhanVienTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(acme.bookStore.books.book.getList),
            columnDefs: [
                {
                title: l('Actions'),
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            }
                        ]
                }
                },
                {
                    text: l('Delete'),
                    confirmMessage: function (data) {
                        return l('DeletionConfirmationMessage', data.record.name);
                    },
                    action: function (data) {
                        acme.oderManager.nhanViens.nhanVien
                            .delete(data.record.id)
                            .then(function () {
                                abp.notify.info(l('SuccessfullyDeleted'));
                                dataTable.ajax.reload();
                            });
                    }
                },

                {
                    title: l('Ten'),
                    data: "Ten"
                },
                {
                    title: l('Tuoi'),
                    data: "Tuoi"
                },
                {
                    title: l('NgaySinh'),
                    data: "NgaySinh",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString();
                    }
                },
                {
                    title: ('QueQuan'),
                    data: "QueQuan"
                },
                {
                    title: l('CreationTime'), data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                }
            ]
        })
    );
    var createModal = new abp.ModalManager(abp.appPath + 'NhanViens/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'NhanVien/EditModal');

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewNhanVienButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });


});
